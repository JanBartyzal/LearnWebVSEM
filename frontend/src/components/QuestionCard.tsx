import { useEffect, useRef, useState } from 'react'
import { useMutation, useQueryClient } from '@tanstack/react-query'
import {
  Badge,
  Button,
  Caption1,
  Card,
  makeStyles,
  mergeClasses,
  MessageBar,
  MessageBarBody,
  MessageBarTitle,
  Text,
  tokens,
} from '@fluentui/react-components'
import { CheckmarkCircleFilled, DismissCircleFilled } from '@fluentui/react-icons'
import { api } from '../api/client.ts'
import type { AnswerResult, QuizQuestion, StudyMode } from '../api/types.ts'
import { FlashCard } from './FlashCard.tsx'
import { ignoreShortcut } from './keyboard.ts'
import { useMotion, useStickyActions } from './motion.ts'

const useStyles = makeStyles({
  root: { display: 'flex', flexDirection: 'column', gap: tokens.spacingVerticalM },
  card: { padding: tokens.spacingHorizontalXL, gap: tokens.spacingVerticalM },
  meta: { display: 'flex', justifyContent: 'space-between', alignItems: 'center', gap: tokens.spacingHorizontalS },
  options: { display: 'flex', flexDirection: 'column', gap: tokens.spacingVerticalS },
  option: {
    justifyContent: 'flex-start',
    textAlign: 'left',
    minHeight: '48px',
    paddingBlock: tokens.spacingVerticalS,
    whiteSpace: 'normal',
    height: 'auto',
  },
  key: {
    flexShrink: 0,
    minWidth: '24px',
    marginRight: tokens.spacingHorizontalS,
    fontWeight: tokens.fontWeightSemibold,
    color: tokens.colorNeutralForeground3,
  },
  correct: {
    border: `2px solid ${tokens.colorPaletteGreenBorderActive}`,
    backgroundColor: tokens.colorPaletteGreenBackground1,
  },
  wrong: {
    border: `2px solid ${tokens.colorPaletteRedBorderActive}`,
    backgroundColor: tokens.colorPaletteRedBackground1,
  },
  verdict: { display: 'flex', alignItems: 'center', gap: tokens.spacingHorizontalXS, marginLeft: 'auto', flexShrink: 0 },
  footer: { display: 'flex', justifyContent: 'space-between', alignItems: 'center', flexWrap: 'wrap', gap: tokens.spacingHorizontalS },
})

interface Props {
  question: QuizQuestion
  mode: StudyMode
  /** Např. „Otázka 3 / 10" */
  position?: string
  /** Kolikrát se karta v seanci už vrátila z horké fronty (0 = první pokus) */
  repeat?: number
  onAnswered?: (result: AnswerResult) => void
  onNext: () => void
  nextLabel?: string
}

/**
 * MCQ otázka s okamžitou zpětnou vazbou. Ovládání: 1–4 výběr, Enter = další.
 * Správnost se nikdy nesděluje jen barvou (ikona + text).
 */
export function QuestionCard({ question, mode, position, repeat = 0, onAnswered, onNext, nextLabel = 'Další' }: Props) {
  const s = useStyles()
  const motion = useMotion()
  const sticky = useStickyActions()
  const qc = useQueryClient()
  const [selected, setSelected] = useState<number | null>(null)
  const [showCard, setShowCard] = useState(false)
  const nextButton = useRef<HTMLButtonElement>(null)

  const answer = useMutation({
    mutationFn: (index: number) => api.answer(question.questionId, index, mode, repeat),
    onSuccess: (r) => {
      if (r.reteach) setShowCard(true)
      qc.invalidateQueries({ queryKey: ['stats'] })
      qc.invalidateQueries({ queryKey: ['review-summary'] })
      qc.invalidateQueries({ queryKey: ['continue'] })
      onAnswered?.(r)
    },
  })
  const result = answer.data

  // Po vyhodnocení přesunout fokus na „Další", aby Enter pokračoval i z klávesnice.
  useEffect(() => {
    if (result) nextButton.current?.focus()
  }, [result])

  const choose = (index: number) => {
    if (selected !== null) return
    setSelected(index)
    answer.mutate(index)
  }

  useEffect(() => {
    const onKey = (e: KeyboardEvent) => {
      if (ignoreShortcut(e)) return
      const n = Number(e.key)
      if (!result && n >= 1 && n <= question.options.length) {
        e.preventDefault()
        choose(question.options[n - 1].index)
      } else if (result && e.key === 'Enter') {
        e.preventDefault()
        onNext()
      }
    }
    window.addEventListener('keydown', onKey)
    return () => window.removeEventListener('keydown', onKey)
  })

  return (
    <div className={s.root}>
      <Card className={s.card}>
        <div className={s.meta}>
          <Caption1>{question.topicName}</Caption1>
          {repeat > 0 && (
            <Badge appearance="tint" color="warning">
              Opakování chyby
            </Badge>
          )}
          {position && <Caption1>{position}</Caption1>}
        </div>
        <Text as="h2" size={500} weight="semibold">
          {question.text}
        </Text>
        <div className={s.options} role="group" aria-label="Možnosti odpovědi">
          {question.options.map((o, i) => {
            const isCorrect = result && o.index === result.correctIndex
            const isWrongPick = result && o.index === selected && !result.isCorrect
            return (
              <Button
                key={o.index}
                className={mergeClasses(s.option, isCorrect && s.correct, isCorrect && motion.pop, isWrongPick && s.wrong, isWrongPick && motion.shake)}
                disabled={selected !== null && !isCorrect && !isWrongPick}
                aria-pressed={o.index === selected}
                onClick={() => choose(o.index)}
              >
                <span className={s.key}>{i + 1}</span>
                <span>{o.text}</span>
                {isCorrect && (
                  <span className={s.verdict}>
                    <CheckmarkCircleFilled color={tokens.colorPaletteGreenForeground1} /> správně
                  </span>
                )}
                {isWrongPick && (
                  <span className={s.verdict}>
                    <DismissCircleFilled color={tokens.colorPaletteRedForeground1} /> tvoje volba
                  </span>
                )}
              </Button>
            )
          })}
        </div>
      </Card>

      {answer.error && (
        <MessageBar intent="error">
          <MessageBarBody>{answer.error.message}</MessageBarBody>
        </MessageBar>
      )}

      {result && (
        <>
          <MessageBar intent={result.isCorrect ? 'success' : 'warning'} className={motion.reveal}>
            <MessageBarBody>
              <MessageBarTitle>
                {result.isCorrect
                  ? 'Správně!'
                  : result.requeue
                    ? 'Tentokrát ne — nevadí, ještě dnes se k ní na konci vrátíme.'
                    : 'Tentokrát ne — nevadí, karta se ti vrátí v opakování.'}
              </MessageBarTitle>
              {result.explanation}
            </MessageBarBody>
          </MessageBar>
          {result.reteach && (
            <Caption1>Tahle karta ti dělá potíže opakovaně — projdi si ji ještě jednou celou.</Caption1>
          )}
          {showCard && (
            <FlashCard type={result.card.type} front={result.card.front} back={result.card.back} flipped onFlip={() => {}} />
          )}
          <div className={mergeClasses(s.footer, sticky.bar)}>
            <Button appearance="subtle" onClick={() => setShowCard((v) => !v)}>
              {showCard ? 'Skrýt kartu' : 'Zobrazit kartu'}
            </Button>
            {result.xpGained > 0 && <Badge appearance="tint" color="success" className={motion.pop}>+{result.xpGained} XP</Badge>}
            <Button ref={nextButton} appearance="primary" onClick={onNext}>
              {nextLabel} (Enter)
            </Button>
          </div>
        </>
      )}
    </div>
  )
}

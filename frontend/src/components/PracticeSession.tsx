import { useEffect, useRef, useState, type ReactNode } from 'react'
import { useQueryClient } from '@tanstack/react-query'
import {
  Body1,
  Caption1,
  Card,
  makeStyles,
  MessageBar,
  MessageBarBody,
  ProgressBar,
  Spinner,
  Text,
  Title2,
  tokens,
} from '@fluentui/react-components'
import { api } from '../api/client.ts'
import type { AnswerResult, QuizQuestion } from '../api/types.ts'
import { useCompleteSession } from './achievements.tsx'
import { QuestionCard } from './QuestionCard.tsx'
import { SessionSummary } from './SessionSummary.tsx'

const useStyles = makeStyles({
  viewer: { maxWidth: '720px', marginInline: 'auto' },
  intro: { display: 'block', marginBottom: tokens.spacingVerticalM, color: tokens.colorNeutralForeground3 },
  mistakes: { display: 'flex', flexDirection: 'column', gap: tokens.spacingVerticalS, width: '100%', textAlign: 'left' },
  mistake: { padding: tokens.spacingHorizontalM, gap: tokens.spacingVerticalXS },
  loading: { marginTop: tokens.spacingVerticalXL },
  progress: { marginBottom: tokens.spacingVerticalM },
})

interface Item {
  question: QuizQuestion
  /** 0 = první pokus, > 0 = návrat z horké fronty */
  repeat: number
}

interface Answered extends Item {
  result: AnswerResult
}

interface Props {
  questions: QuizQuestion[]
  mode: 'Quiz' | 'Review'
  title: string
  intro: string
  summaryActions: ReactNode
  /** Pro záznam dokončené seance (série dní, statistiky) */
  subjectSlug?: string
  topicId?: number
}

/**
 * Seance otázek s horkou frontou (BA §2.3 pravidlo 3): chybnou kartu backend označí `requeue`
 * a seance ji po poslední otázce vrátí na konec — s jinou otázkou, je-li k dispozici.
 * Skóre ve shrnutí počítá jen první pokusy; opravy chyb se ukazují zvlášť.
 */
export function PracticeSession({ questions, mode, title, intro, summaryActions, subjectSlug, topicId }: Props) {
  const s = useStyles()
  const qc = useQueryClient()
  const [items, setItems] = useState<Item[]>(() => questions.map((question) => ({ question, repeat: 0 })))
  const [index, setIndex] = useState(0)
  const [answers, setAnswers] = useState<Answered[]>([])
  const [pending, setPending] = useState<Item[]>([])
  const [loadingRepeats, setLoadingRepeats] = useState(false)
  const [repeatError, setRepeatError] = useState<string | null>(null)
  const done = index >= items.length

  // Další otázka začíná nahoře (na mobilu bývá předchozí vysvětlení odrolované).
  useEffect(() => {
    window.scrollTo({ top: 0 })
  }, [index])
  const completeSession = useCompleteSession()
  const recorded = useRef(false)

  const finish = () => {
    setIndex(items.length)
    if (!recorded.current) {
      recorded.current = true
      const first = answers.filter((a) => a.repeat === 0)
      void completeSession({
        mode,
        subjectSlug,
        topicId,
        answered: first.length,
        correct: first.filter((a) => a.result.isCorrect).length,
      })
    }
    qc.invalidateQueries({ queryKey: ['subject'] })
    qc.invalidateQueries({ queryKey: ['subjects'] })
    qc.invalidateQueries({ queryKey: ['review-summary'] })
  }

  const next = async () => {
    if (index + 1 < items.length) return setIndex(index + 1)
    if (pending.length === 0) return finish()

    // Konec hlavní fronty — doplnit chybované karty (horká fronta).
    setLoadingRepeats(true)
    try {
      const repeats = await api.quiz({
        cardIds: pending.map((p) => p.question.cardId),
        mode,
        count: pending.length,
        excludeQuestionIds: pending.map((p) => p.question.questionId),
      })
      const repeatOf = new Map(pending.map((p) => [p.question.cardId, p.repeat]))
      setItems((xs) => [...xs, ...repeats.map((question) => ({ question, repeat: repeatOf.get(question.cardId) ?? 1 }))])
      setPending([])
      setIndex(index + 1)
    } catch (e) {
      setRepeatError(e instanceof Error ? e.message : 'Nepodařilo se načíst opakování chyb.')
      finish()
    } finally {
      setLoadingRepeats(false)
    }
  }

  if (done) return <Summary answers={answers} mode={mode} actions={summaryActions} error={repeatError} />

  if (loadingRepeats) return <Spinner className={s.loading} label="Vracíme se k chybám…" />

  const item = items[index]
  const isLastPlanned = index + 1 >= items.length
  return (
    <div className={s.viewer}>
      <Title2 as="h1">{title}</Title2>
      <Caption1 className={s.intro}>{item.repeat > 0 ? 'Ještě jednou karty, u kterých to dnes nevyšlo.' : intro}</Caption1>
      <ProgressBar className={s.progress} value={index / items.length} thickness="large"
        aria-label={`Hotovo ${index} z ${items.length} otázek`} />
      <QuestionCard
        key={`${item.question.questionId}-${index}`}
        question={item.question}
        mode={mode}
        repeat={item.repeat}
        position={`${index + 1} / ${items.length}`}
        onAnswered={(result) => {
          setAnswers((a) => [...a, { ...item, result }])
          if (result.requeue) setPending((p) => [...p, { question: item.question, repeat: item.repeat + 1 }])
        }}
        onNext={next}
        nextLabel={isLastPlanned ? 'Pokračovat' : 'Další otázka'}
      />
    </div>
  )
}

function Summary({ answers, mode, actions, error }: { answers: Answered[]; mode: 'Quiz' | 'Review'; actions: ReactNode; error: string | null }) {
  const s = useStyles()
  const first = answers.filter((a) => a.repeat === 0)
  const correct = first.filter((a) => a.result.isCorrect).length
  const pct = first.length ? Math.round((100 * correct) / first.length) : 0
  const xp = answers.reduce((sum, a) => sum + a.result.xpGained, 0)
  const repeats = answers.filter((a) => a.repeat > 0)
  const fixed = repeats.filter((a) => a.result.isCorrect).length
  const mistakes = first.filter((a) => !a.result.isCorrect)

  const stats = [
    { label: 'správně napoprvé', value: `${correct}/${first.length}` },
    { label: 'úspěšnost', value: `${pct} %` },
    ...(repeats.length ? [{ label: 'chyby opraveny', value: `${fixed}/${repeats.length}` }] : []),
    { label: 'získáno', value: `+${xp} XP` },
  ]

  const message =
    mode === 'Review'
      ? mistakes.length
        ? 'Karty, které jsi věděl, se vrátí za delší dobu. Chybné začínají znovu od zítřka.'
        : 'Všechno sedí — karty postoupily do vyšších krabic a vrátí se za delší dobu.'
      : mistakes.length
        ? 'Chybné karty se ti vrátí v opakování, dokud je nebudeš mít v malíčku.'
        : 'Bez chyby — tohle téma už sedí.'

  return (
    <div className={s.viewer}>
      {error && (
        <MessageBar intent="warning">
          <MessageBarBody>{error}</MessageBarBody>
        </MessageBar>
      )}
      <SessionSummary
        title={pct >= 85 ? 'Výborně!' : pct >= 60 ? 'Dobrá práce' : 'Každá chyba je informace'}
        message={message}
        stats={stats}
        actions={actions}
      >
        {mistakes.length > 0 && (
          <div className={s.mistakes}>
            <Text weight="semibold">K zopakování</Text>
            {mistakes.map(({ question, result }) => (
              <Card key={question.questionId} className={s.mistake} appearance="filled-alternative">
                <Text weight="semibold">{question.text}</Text>
                <Body1>Správně: {question.options.find((o) => o.index === result.correctIndex)?.text}</Body1>
                <Caption1>{result.explanation}</Caption1>
              </Card>
            ))}
          </div>
        )}
      </SessionSummary>
    </div>
  )
}

import { useState } from 'react'
import { useQuery, useQueryClient } from '@tanstack/react-query'
import { useNavigate, useSearchParams } from 'react-router-dom'
import {
  Body1,
  Button,
  Caption1,
  Card,
  makeStyles,
  MessageBar,
  MessageBarBody,
  Text,
  Title2,
  tokens,
} from '@fluentui/react-components'
import { api } from '../api/client.ts'
import type { AnswerResult, QuizQuestion } from '../api/types.ts'
import { PageState } from '../components/PageState.tsx'
import { QuestionCard } from '../components/QuestionCard.tsx'
import { SessionSummary } from '../components/SessionSummary.tsx'

const QUIZ_LENGTH = 10

const useStyles = makeStyles({
  viewer: { maxWidth: '720px', marginInline: 'auto' },
  intro: { display: 'block', marginBottom: tokens.spacingVerticalM, color: tokens.colorNeutralForeground3 },
  mistakes: { display: 'flex', flexDirection: 'column', gap: tokens.spacingVerticalS, width: '100%', textAlign: 'left' },
  mistake: { padding: tokens.spacingHorizontalM, gap: tokens.spacingVerticalXS },
})

/** Procvičování nad tématem (?tema=ID) nebo celým předmětem (?predmet=slug). */
export function QuizPage() {
  const [params] = useSearchParams()
  const topicId = params.get('tema') ? Number(params.get('tema')) : undefined
  const subjectSlug = params.get('predmet') ?? undefined
  const [attempt, setAttempt] = useState(0)

  const { data, isLoading, error } = useQuery({
    queryKey: ['quiz', topicId, subjectSlug, attempt],
    queryFn: () => api.quiz({ topicId, subjectSlug, mode: 'Quiz', count: QUIZ_LENGTH }),
    staleTime: Infinity,
    gcTime: 0,
    refetchOnWindowFocus: false,
    enabled: topicId !== undefined || subjectSlug !== undefined,
  })

  return (
    <>
      <PageState isLoading={isLoading} error={error} />
      {data && data.length === 0 && (
        <MessageBar>
          <MessageBarBody>Tady zatím nejsou žádné otázky.</MessageBarBody>
        </MessageBar>
      )}
      {data && data.length > 0 && (
        <QuizSession key={attempt} questions={data} subjectSlug={subjectSlug} onRestart={() => setAttempt((a) => a + 1)} />
      )}
    </>
  )
}

function QuizSession({ questions, subjectSlug, onRestart }: { questions: QuizQuestion[]; subjectSlug?: string; onRestart: () => void }) {
  const s = useStyles()
  const navigate = useNavigate()
  const qc = useQueryClient()
  const [index, setIndex] = useState(0)
  const [results, setResults] = useState<{ question: QuizQuestion; result: AnswerResult }[]>([])
  const done = index >= questions.length

  if (done) {
    const correct = results.filter((r) => r.result.isCorrect).length
    const xp = results.reduce((sum, r) => sum + r.result.xpGained, 0)
    const pct = Math.round((100 * correct) / results.length)
    const mistakes = results.filter((r) => !r.result.isCorrect)
    return (
      <div className={s.viewer}>
        <SessionSummary
          title={pct >= 85 ? 'Výborně!' : pct >= 60 ? 'Dobrá práce' : 'Každá chyba je informace'}
          message={
            mistakes.length
              ? 'Chybné karty se ti vrátí v opakování, dokud je nebudeš mít v malíčku.'
              : 'Bez chyby — tohle téma už sedí.'
          }
          stats={[
            { label: 'správně', value: `${correct}/${results.length}` },
            { label: 'úspěšnost', value: `${pct} %` },
            { label: 'získáno', value: `+${xp} XP` },
          ]}
          actions={
            <>
              <Button appearance="primary" onClick={onRestart}>
                Další kvíz
              </Button>
              <Button onClick={() => (subjectSlug ? navigate(`/predmet/${subjectSlug}`) : navigate(-1))}>Zpět</Button>
            </>
          }
        >
          {mistakes.length > 0 && (
            <div className={s.mistakes}>
              <Text weight="semibold">K zopakování</Text>
              {mistakes.map(({ question, result }) => (
                <Card key={question.questionId} className={s.mistake} appearance="filled-alternative">
                  <Text weight="semibold">{question.text}</Text>
                  <Body1>
                    Správně: {question.options.find((o) => o.index === result.correctIndex)?.text}
                  </Body1>
                  <Caption1>{result.explanation}</Caption1>
                </Card>
              ))}
            </div>
          )}
        </SessionSummary>
      </div>
    )
  }

  const q = questions[index]
  return (
    <div className={s.viewer}>
      <Title2 as="h1">Procvičování</Title2>
      <Caption1 className={s.intro}>Přednost mají karty, se kterými jsi měl potíže, a karty k opakování.</Caption1>
      <QuestionCard
        key={q.questionId}
        question={q}
        mode="Quiz"
        position={`Otázka ${index + 1} / ${questions.length}`}
        onAnswered={(result) => setResults((r) => [...r, { question: q, result }])}
        onNext={() => {
          setIndex(index + 1)
          if (index + 1 >= questions.length) qc.invalidateQueries({ queryKey: ['subject'] })
        }}
        nextLabel={index + 1 < questions.length ? 'Další otázka' : 'Vyhodnotit'}
      />
    </div>
  )
}

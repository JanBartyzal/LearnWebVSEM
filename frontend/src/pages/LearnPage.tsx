import { useCallback, useEffect, useState } from 'react'
import { useMutation, useQuery, useQueryClient } from '@tanstack/react-query'
import { useNavigate, useParams } from 'react-router-dom'
import {
  Breadcrumb,
  BreadcrumbButton,
  BreadcrumbDivider,
  BreadcrumbItem,
  Button,
  Caption1,
  makeStyles,
  MessageBar,
  MessageBarBody,
  ProgressBar,
  Spinner,
  Title2,
  tokens,
} from '@fluentui/react-components'
import { ArrowLeftRegular, ArrowRightRegular, ArrowSyncRegular } from '@fluentui/react-icons'
import { api } from '../api/client.ts'
import type { QuizQuestion, TopicDetail } from '../api/types.ts'
import { FlashCard } from '../components/FlashCard.tsx'
import { ignoreShortcut } from '../components/keyboard.ts'
import { PageState } from '../components/PageState.tsx'
import { QuestionCard } from '../components/QuestionCard.tsx'
import { SessionSummary } from '../components/SessionSummary.tsx'

/** Po kolika kartách přijde kontrolní mini-kvíz (BA §2.2 B: rytmus „nauč se → ověř"). */
const BLOCK_SIZE = 5
const QUIZ_SIZE = 3

const useStyles = makeStyles({
  viewer: { maxWidth: '720px', marginInline: 'auto', marginTop: tokens.spacingVerticalM },
  progress: { marginBlock: tokens.spacingVerticalM },
  nav: {
    display: 'flex',
    justifyContent: 'space-between',
    alignItems: 'center',
    gap: tokens.spacingHorizontalS,
    marginTop: tokens.spacingVerticalL,
  },
  quizIntro: { display: 'block', marginBottom: tokens.spacingVerticalS, color: tokens.colorNeutralForeground3 },
})

type Phase = 'card' | 'quiz' | 'summary'

export function LearnPage() {
  const id = Number(useParams().id)
  const { data, isLoading, error } = useQuery({
    queryKey: ['topic', id],
    queryFn: () => api.topic(id),
    // Seance si drží vlastní stav; po návratu na stránku chceme čerstvá data.
    staleTime: 0,
    refetchOnWindowFocus: false,
  })

  return (
    <>
      <TopicBreadcrumb topic={data} />
      <PageState isLoading={isLoading} error={error} />
      {data && <LearnSession key={data.id} topic={data} />}
    </>
  )
}

function TopicBreadcrumb({ topic }: { topic?: TopicDetail }) {
  const navigate = useNavigate()
  return (
    <Breadcrumb>
      <BreadcrumbItem>
        <BreadcrumbButton onClick={() => navigate('/')}>Předměty</BreadcrumbButton>
      </BreadcrumbItem>
      <BreadcrumbDivider />
      <BreadcrumbItem>
        <BreadcrumbButton onClick={() => topic && navigate(`/predmet/${topic.subjectSlug}`)}>
          {topic?.subjectName ?? '…'}
        </BreadcrumbButton>
      </BreadcrumbItem>
      <BreadcrumbDivider />
      <BreadcrumbItem>
        <BreadcrumbButton current>{topic?.name ?? '…'}</BreadcrumbButton>
      </BreadcrumbItem>
    </Breadcrumb>
  )
}

function LearnSession({ topic }: { topic: TopicDetail }) {
  const s = useStyles()
  const navigate = useNavigate()
  const qc = useQueryClient()
  const cards = topic.cards
  const firstUnseen = cards.findIndex((c) => !c.seen)
  const alreadyDone = firstUnseen < 0

  const [index, setIndex] = useState(alreadyDone ? 0 : firstUnseen)
  const [flipped, setFlipped] = useState(false)
  const [phase, setPhase] = useState<Phase>('card')
  const [block, setBlock] = useState<number[]>([])
  const [quiz, setQuiz] = useState<QuizQuestion[]>([])
  const [quizIndex, setQuizIndex] = useState(0)
  const [session, setSession] = useState({ learned: 0, xp: 0, correct: 0, answered: 0, topicCompleted: false })

  const card = cards[index]
  const isLast = index >= cards.length - 1

  const finishBlock = useMutation({
    mutationFn: (cardIds: number[]) => api.quiz({ cardIds, mode: 'Learn', count: Math.min(QUIZ_SIZE, cardIds.length) }),
    onSuccess: (questions) => {
      if (questions.length === 0) return advanceAfterQuiz()
      setQuiz(questions)
      setQuizIndex(0)
      setPhase('quiz')
    },
  })

  const learned = useMutation({
    mutationFn: api.learned,
    onSuccess: (r) => {
      setSession((x) => ({ ...x, learned: x.learned + 1, xp: x.xp + r.xpGained, topicCompleted: x.topicCompleted || r.topicCompleted }))
      qc.invalidateQueries({ queryKey: ['stats'] })
    },
  })

  const advanceAfterQuiz = useCallback(() => {
    setBlock([])
    if (isLast) {
      setPhase('summary')
      qc.invalidateQueries({ queryKey: ['subject', topic.subjectSlug] })
      qc.invalidateQueries({ queryKey: ['subjects'] })
    } else {
      setIndex((i) => i + 1)
      setFlipped(false)
      setPhase('card')
    }
  }, [isLast, qc, topic.subjectSlug])

  const understood = useCallback(() => {
    if (!card || learned.isPending || finishBlock.isPending) return
    learned.mutate(card.id)
    const nextBlock = [...block, card.id]
    if (nextBlock.length >= BLOCK_SIZE || isLast) {
      finishBlock.mutate(nextBlock)
    } else {
      setBlock(nextBlock)
      setIndex((i) => i + 1)
      setFlipped(false)
    }
  }, [block, card, finishBlock, isLast, learned])

  const back = useCallback(() => {
    if (index === 0) return
    setIndex((i) => i - 1)
    setBlock((b) => b.slice(0, -1))
    setFlipped(false)
  }, [index])

  useEffect(() => {
    if (phase !== 'card') return
    const onKey = (e: KeyboardEvent) => {
      if (ignoreShortcut(e)) return
      if (e.key === ' ') {
        e.preventDefault()
        setFlipped((f) => !f)
      } else if (e.key === 'Enter' || e.key === 'ArrowRight') {
        e.preventDefault()
        if (card?.type === 'term' && !flipped) setFlipped(true)
        else understood()
      } else if (e.key === 'ArrowLeft') back()
    }
    window.addEventListener('keydown', onKey)
    return () => window.removeEventListener('keydown', onKey)
  }, [back, card, flipped, phase, understood])

  if (cards.length === 0)
    return (
      <MessageBar>
        <MessageBarBody>Téma zatím nemá žádné karty.</MessageBarBody>
      </MessageBar>
    )

  if (phase === 'summary') {
    const pct = session.answered ? Math.round((100 * session.correct) / session.answered) : 0
    return (
      <div className={s.viewer}>
        <SessionSummary
          title={session.topicCompleted ? 'Téma probráno!' : 'Seance dokončena'}
          message={
            session.topicCompleted
              ? 'Všechny karty tématu máš za sebou. Zítra se ti první z nich vrátí k opakování.'
              : 'Dobrá práce. Probrané karty se ti budou vracet k opakování.'
          }
          stats={[
            { label: 'probraných karet', value: String(session.learned) },
            { label: 'kontrolní otázky', value: session.answered ? `${session.correct}/${session.answered} (${pct} %)` : '—' },
            { label: 'získáno', value: `+${session.xp} XP` },
          ]}
          actions={
            <>
              <Button appearance="primary" onClick={() => navigate(`/procvicovani?tema=${topic.id}`)}>
                Procvičit téma
              </Button>
              <Button onClick={() => navigate(`/predmet/${topic.subjectSlug}`)}>Zpět na předmět</Button>
            </>
          }
        />
      </div>
    )
  }

  if (phase === 'quiz') {
    const q = quiz[quizIndex]
    return (
      <div className={s.viewer}>
        <Title2 as="h1">Rychlé ověření</Title2>
        <Caption1 className={s.quizIntro}>Otázky z karet, které jsi právě prošel.</Caption1>
        <QuestionCard
          key={q.questionId}
          question={q}
          mode="Learn"
          position={`${quizIndex + 1} / ${quiz.length}`}
          onAnswered={(r) =>
            setSession((x) => ({ ...x, answered: x.answered + 1, correct: x.correct + (r.isCorrect ? 1 : 0), xp: x.xp + r.xpGained }))
          }
          onNext={() => (quizIndex + 1 < quiz.length ? setQuizIndex(quizIndex + 1) : advanceAfterQuiz())}
          nextLabel={quizIndex + 1 < quiz.length ? 'Další otázka' : isLast ? 'Dokončit' : 'Pokračovat v učení'}
        />
      </div>
    )
  }

  return (
    <div className={s.viewer}>
      <Title2 as="h1">{topic.name}</Title2>
      {alreadyDone && index === 0 && (
        <MessageBar>
          <MessageBarBody>Celé téma už máš probrané — tohle je opakovací průchod.</MessageBarBody>
        </MessageBar>
      )}
      <ProgressBar className={s.progress} value={(index + 1) / cards.length} thickness="large"
        aria-label={`Karta ${index + 1} z ${cards.length}`} />
      <FlashCard type={card.type} front={card.front} back={card.back} flipped={flipped}
        onFlip={() => setFlipped((f) => !f)} position={`${index + 1} / ${cards.length}`} />
      <div className={s.nav}>
        <Button icon={<ArrowLeftRegular />} disabled={index === 0} onClick={back}>
          Zpět
        </Button>
        {card.type === 'term' && !flipped ? (
          <Button appearance="primary" icon={<ArrowSyncRegular />} onClick={() => setFlipped(true)}>
            Otočit
          </Button>
        ) : (
          <Button appearance="primary" icon={finishBlock.isPending ? <Spinner size="tiny" /> : <ArrowRightRegular />}
            iconPosition="after" disabled={finishBlock.isPending} onClick={understood}>
            Rozumím
          </Button>
        )}
      </div>
    </div>
  )
}

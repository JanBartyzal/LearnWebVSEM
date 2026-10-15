import { useCallback, useEffect, useMemo, useState } from 'react'
import { useMutation, useQuery, useQueryClient } from '@tanstack/react-query'
import { useNavigate, useParams } from 'react-router-dom'
import {
  Badge,
  Body1,
  Button,
  Caption1,
  Card,
  Dialog,
  DialogActions,
  DialogBody,
  DialogContent,
  DialogSurface,
  DialogTitle,
  Field,
  makeStyles,
  mergeClasses,
  MessageBar,
  MessageBarBody,
  Radio,
  RadioGroup,
  Spinner,
  Switch,
  Text,
  Title2,
  tokens,
} from '@fluentui/react-components'
import { ArrowLeftRegular, ArrowRightRegular, CheckmarkCircleFilled, DismissCircleFilled, TimerRegular } from '@fluentui/react-icons'
import { api } from '../api/client.ts'
import type { ExamOutcome, ExamPaper } from '../api/types.ts'
import { useNotifyBadges } from '../components/achievements.tsx'
import { ignoreShortcut } from '../components/keyboard.ts'
import { MasteryBar } from '../components/MasteryBar.tsx'
import { PageState } from '../components/PageState.tsx'
import { SessionSummary } from '../components/SessionSummary.tsx'
import { useDocumentTitle } from '../components/useDocumentTitle.ts'

const COUNTS = [20, 25, 30]

const useStyles = makeStyles({
  viewer: { maxWidth: '720px', marginInline: 'auto', display: 'flex', flexDirection: 'column', gap: tokens.spacingVerticalM },
  card: { padding: tokens.spacingHorizontalXL, gap: tokens.spacingVerticalM },
  bar: { display: 'flex', justifyContent: 'space-between', alignItems: 'center', flexWrap: 'wrap', gap: tokens.spacingHorizontalS },
  timer: { display: 'flex', alignItems: 'center', gap: tokens.spacingHorizontalXS, fontVariantNumeric: 'tabular-nums' },
  options: { display: 'flex', flexDirection: 'column', gap: tokens.spacingVerticalS },
  option: { justifyContent: 'flex-start', textAlign: 'left', minHeight: '48px', whiteSpace: 'normal', height: 'auto', paddingBlock: tokens.spacingVerticalS },
  key: { flexShrink: 0, minWidth: '24px', marginRight: tokens.spacingHorizontalS, fontWeight: tokens.fontWeightSemibold, color: tokens.colorNeutralForeground3 },
  chosen: { border: `2px solid ${tokens.colorBrandStroke1}`, backgroundColor: tokens.colorBrandBackground2 },
  nav: { display: 'flex', justifyContent: 'space-between', gap: tokens.spacingHorizontalS },
  grid: { display: 'flex', flexWrap: 'wrap', gap: tokens.spacingHorizontalXS },
  cell: { minWidth: '36px', paddingInline: 0 },
  topics: { display: 'flex', flexDirection: 'column', gap: tokens.spacingVerticalS, width: '100%', textAlign: 'left' },
  item: { padding: tokens.spacingHorizontalM, gap: tokens.spacingVerticalXS, textAlign: 'left' },
  verdict: { display: 'flex', alignItems: 'center', gap: tokens.spacingHorizontalXS },
})

/** Simulace zkoušky (BA §2.2 E) — bez průběžné zpětné vazby, vyhodnocení až po odevzdání. */
export function ExamPage() {
  const { slug = '' } = useParams()
  const [paper, setPaper] = useState<ExamPaper | null>(null)
  const [outcome, setOutcome] = useState<ExamOutcome | null>(null)
  // null = výchozí: u certifikačního kurzu s limitem jako u skutečné zkoušky, jinak bez limitu.
  const [timedChoice, setTimed] = useState<boolean | null>(null)
  const [round, setRound] = useState(0)
  const subject = useQuery({ queryKey: ['subject', slug], queryFn: () => api.subject(slug) })
  const timed = timedChoice ?? !!subject.data?.exam
  useDocumentTitle('Zkouška nanečisto')

  if (outcome)
    return <ExamResult key={round} outcome={outcome} slug={slug} onAgain={() => { setOutcome(null); setPaper(null); setRound((r) => r + 1) }} />
  if (paper?.questions.length === 0)
    return (
      <MessageBar intent="info">
        <MessageBarBody>Tento kurz zatím nemá žádné otázky — karty se připravují.</MessageBarBody>
      </MessageBar>
    )
  if (paper) return <ExamRunner paper={paper} timed={timed} onSubmitted={setOutcome} />
  return <ExamIntro slug={slug} timed={timed} onTimed={setTimed} onStart={setPaper} />
}

function ExamIntro({ slug, timed, onTimed, onStart }: { slug: string; timed: boolean; onTimed: (v: boolean) => void; onStart: (p: ExamPaper) => void }) {
  const s = useStyles()
  const navigate = useNavigate()
  const [count, setCount] = useState(25)
  const subject = useQuery({ queryKey: ['subject', slug], queryFn: () => api.subject(slug) })
  const exam = subject.data?.exam
  const compose = useMutation({ mutationFn: () => api.composeExam(slug, count), onSuccess: onStart })

  return (
    <div className={s.viewer}>
      <PageState isLoading={subject.isLoading} error={subject.error} />
      <Title2 as="h1">Zkouška nanečisto{subject.data ? ` — ${subject.data.name}` : ''}</Title2>
      <Card className={s.card}>
        <Body1>
          Otázky napříč všemi tématy předmětu, úměrně jejich rozsahu. Během testu se nedozvíš, jestli odpovídáš správně —
          vyhodnocení přijde až po odevzdání, i s rozpadem po tématech a vysvětlením chyb. Chybné karty se ti zařadí do opakování.
        </Body1>
        {exam ? (
          <MessageBar intent="info">
            <MessageBarBody>
              Formát jako u certifikace: <strong>{exam.questions} otázek</strong>, <strong>{exam.minutes} minut</strong>,
              hranice úspěchu <strong>{exam.passPercent} %</strong>.
            </MessageBarBody>
          </MessageBar>
        ) : (
          <Field label="Počet otázek">
            <RadioGroup layout="horizontal" value={String(count)} onChange={(_, d) => setCount(Number(d.value))}>
              {COUNTS.map((n) => <Radio key={n} value={String(n)} label={String(n)} />)}
            </RadioGroup>
          </Field>
        )}
        <Switch checked={timed} onChange={(_, d) => onTimed(d.checked)}
          label={exam ? `Časový limit ${exam.minutes} min` : `Časový limit (${count} min — 1 minuta na otázku)`} />
        {compose.error && (
          <MessageBar intent="error"><MessageBarBody>{compose.error.message}</MessageBarBody></MessageBar>
        )}
        <div className={s.nav}>
          <Button onClick={() => navigate(`/predmet/${slug}`)}>Zpět</Button>
          <Button appearance="primary" disabled={compose.isPending} icon={compose.isPending ? <Spinner size="tiny" /> : undefined}
            onClick={() => compose.mutate()}>
            Spustit zkoušku
          </Button>
        </div>
      </Card>
    </div>
  )
}

function ExamRunner({ paper, timed, onSubmitted }: { paper: ExamPaper; timed: boolean; onSubmitted: (o: ExamOutcome) => void }) {
  const s = useStyles()
  const qc = useQueryClient()
  const notify = useNotifyBadges()
  const [startedAt] = useState(() => new Date().toISOString())
  const [index, setIndex] = useState(0)
  const [answers, setAnswers] = useState<Record<number, number>>({})
  const [confirm, setConfirm] = useState(false)
  const [deadline] = useState(() => Date.now() + paper.timeLimitMinutes * 60_000)
  const [left, setLeft] = useState(paper.timeLimitMinutes * 60)

  const questions = paper.questions
  const q = questions[index]
  const answered = Object.keys(answers).length
  const unanswered = questions.length - answered

  const submit = useMutation({
    mutationFn: () =>
      api.submitExam(paper.subjectSlug, startedAt,
        questions.map((x) => ({ questionId: x.questionId, selectedIndex: answers[x.questionId] ?? null }))),
    onSuccess: (o) => {
      notify(o.newBadges)
      for (const key of ['stats', 'stats-overview', 'subject-stats', 'subject', 'subjects', 'review-summary', 'continue'])
        qc.invalidateQueries({ queryKey: [key] })
      onSubmitted(o)
    },
  })

  // Časový limit: po vypršení se test odevzdá sám (nezodpovězené otázky se počítají jako chyba).
  useEffect(() => {
    if (!timed) return
    const id = window.setInterval(() => {
      const sec = Math.max(0, Math.round((deadline - Date.now()) / 1000))
      setLeft(sec)
      if (sec === 0 && !submit.isPending && !submit.isSuccess) submit.mutate()
    }, 1000)
    return () => window.clearInterval(id)
  }, [deadline, submit, timed])

  const choose = useCallback((optionIndex: number) => setAnswers((a) => ({ ...a, [q.questionId]: optionIndex })), [q.questionId])
  const go = useCallback((i: number) => setIndex(Math.max(0, Math.min(questions.length - 1, i))), [questions.length])

  useEffect(() => {
    const onKey = (e: KeyboardEvent) => {
      if (ignoreShortcut(e) || confirm) return
      const n = Number(e.key)
      if (n >= 1 && n <= q.options.length) {
        e.preventDefault()
        choose(q.options[n - 1].index)
      } else if (e.key === 'Enter' || e.key === 'ArrowRight') {
        e.preventDefault()
        go(index + 1)
      } else if (e.key === 'ArrowLeft') go(index - 1)
    }
    window.addEventListener('keydown', onKey)
    return () => window.removeEventListener('keydown', onKey)
  }, [choose, confirm, go, index, q])

  const mmss = useMemo(() => `${Math.floor(left / 60)}:${String(left % 60).padStart(2, '0')}`, [left])

  if (submit.isPending) return <Spinner label="Vyhodnocuji zkoušku…" />

  return (
    <div className={s.viewer}>
      <div className={s.bar}>
        <Title2 as="h1">Zkouška — {paper.subjectName}</Title2>
        {timed && (
          <Badge size="large" appearance="tint" color={left < 60 ? 'danger' : 'informative'} className={s.timer}
            icon={<TimerRegular />} aria-label={`Zbývá ${mmss}`}>
            {mmss}
          </Badge>
        )}
      </div>
      <Card className={s.card}>
        <div className={s.bar}>
          <Caption1>{q.topicName}</Caption1>
          <Caption1>Otázka {index + 1} / {questions.length} · zodpovězeno {answered}</Caption1>
        </div>
        <Text as="h2" size={500} weight="semibold">{q.text}</Text>
        <div className={s.options} role="radiogroup" aria-label="Možnosti odpovědi">
          {q.options.map((o, i) => {
            const isChosen = answers[q.questionId] === o.index
            return (
              <Button key={o.index} role="radio" aria-checked={isChosen} className={mergeClasses(s.option, isChosen && s.chosen)}
                onClick={() => choose(o.index)}>
                <span className={s.key}>{i + 1}</span>
                <span>{o.text}</span>
                {isChosen && <Caption1 style={{ marginLeft: 'auto' }}>vybráno</Caption1>}
              </Button>
            )
          })}
        </div>
        <div className={s.nav}>
          <Button icon={<ArrowLeftRegular />} disabled={index === 0} onClick={() => go(index - 1)}>Předchozí</Button>
          {index + 1 < questions.length ? (
            <Button appearance="primary" icon={<ArrowRightRegular />} iconPosition="after" onClick={() => go(index + 1)}>Další</Button>
          ) : (
            <Button appearance="primary" onClick={() => (unanswered ? setConfirm(true) : submit.mutate())}>Odevzdat</Button>
          )}
        </div>
      </Card>

      <Caption1>Přehled otázek (číslo s tečkou = zodpovězeno):</Caption1>
      <div className={s.grid}>
        {questions.map((x, i) => {
          const done = answers[x.questionId] !== undefined
          return (
            <Button key={x.questionId} size="small" className={s.cell} appearance={i === index ? 'primary' : done ? 'secondary' : 'subtle'}
              aria-label={`Otázka ${i + 1}${done ? ', zodpovězeno' : ', bez odpovědi'}`} aria-current={i === index}
              onClick={() => go(i)}>
              {i + 1}{done ? '•' : ''}
            </Button>
          )
        })}
      </div>
      <div>
        <Button onClick={() => (unanswered ? setConfirm(true) : submit.mutate())}>Odevzdat zkoušku</Button>
      </div>
      {submit.error && <MessageBar intent="error"><MessageBarBody>{submit.error.message}</MessageBarBody></MessageBar>}

      <Dialog open={confirm} onOpenChange={(_, d) => setConfirm(d.open)}>
        <DialogSurface>
          <DialogBody>
            <DialogTitle>Odevzdat i s nezodpovězenými otázkami?</DialogTitle>
            <DialogContent>Bez odpovědi zůstává {unanswered} z {questions.length} otázek — počítají se jako chyba.</DialogContent>
            <DialogActions>
              <Button onClick={() => setConfirm(false)}>Pokračovat v testu</Button>
              <Button appearance="primary" onClick={() => { setConfirm(false); submit.mutate() }}>Odevzdat</Button>
            </DialogActions>
          </DialogBody>
        </DialogSurface>
      </Dialog>
    </div>
  )
}

function ExamResult({ outcome, slug, onAgain }: { outcome: ExamOutcome; slug: string; onAgain: () => void }) {
  const s = useStyles()
  const navigate = useNavigate()
  const mistakes = outcome.items.filter((i) => !i.isCorrect)
  const mistakeCards = [...new Set(mistakes.map((m) => m.cardId))]

  return (
    <div className={s.viewer}>
      <SessionSummary
        title={outcome.passed ? 'U zkoušky bys prošel!' : outcome.percent >= outcome.passPercent - 15 ? 'Na dobré cestě' : 'Každá chyba je informace'}
        message={
          outcome.passed
            ? `Výsledek ${outcome.percent} % (hranice ${outcome.passPercent} %) — bonus za zkoušku nanečisto je tvůj.`
            : 'Podívej se na nejslabší témata níže — chybné karty se ti zařadily do opakování.'
        }
        stats={[
          { label: 'správně', value: `${outcome.correct}/${outcome.total}` },
          { label: 'úspěšnost', value: `${outcome.percent} %` },
          { label: 'získáno', value: `+${outcome.xpGained} XP` },
        ]}
        actions={
          <>
            {mistakeCards.length > 0 && (
              <Button appearance="primary" onClick={() => navigate(`/procvicovani?karty=${mistakeCards.join(',')}&predmet=${slug}`)}>
                Procvičit chybné karty
              </Button>
            )}
            <Button onClick={onAgain}>Nová zkouška</Button>
            <Button onClick={() => navigate(`/statistiky?predmet=${slug}`)}>Statistiky</Button>
          </>
        }
      >
        <div className={s.topics}>
          <Text weight="semibold">Výsledek po tématech (nejslabší nahoře)</Text>
          {outcome.topics.map((t) => (
            <MasteryBar key={t.topicId} value={t.total ? t.correct / t.total : 0} label={`${t.topicName} — ${t.correct}/${t.total}`} />
          ))}
        </div>
      </SessionSummary>

      {mistakes.length > 0 && (
        <>
          <Text weight="semibold" size={400}>Chyby s vysvětlením</Text>
          {mistakes.map((m) => (
            <Card key={m.questionId} className={s.item} appearance="filled-alternative">
              <Caption1>{m.topicName}</Caption1>
              <Text weight="semibold">{m.text}</Text>
              <span className={s.verdict}>
                <DismissCircleFilled color={tokens.colorPaletteRedForeground1} />
                <Body1>Tvoje odpověď: {m.selectedIndex === null ? 'bez odpovědi' : m.options[m.selectedIndex]}</Body1>
              </span>
              <span className={s.verdict}>
                <CheckmarkCircleFilled color={tokens.colorPaletteGreenForeground1} />
                <Body1>Správně: {m.options[m.correctIndex]}</Body1>
              </span>
              <Caption1>{m.explanation}</Caption1>
            </Card>
          ))}
        </>
      )}
    </div>
  )
}

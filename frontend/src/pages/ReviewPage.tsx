import { useState } from 'react'
import { useQuery } from '@tanstack/react-query'
import { useNavigate, useSearchParams } from 'react-router-dom'
import { Body1, Button, Card, makeStyles, Text, Title2, tokens } from '@fluentui/react-components'
import { CheckmarkStarburstFilled } from '@fluentui/react-icons'
import { api } from '../api/client.ts'
import { ContinueCard } from '../components/ContinueCard.tsx'
import { PageState } from '../components/PageState.tsx'
import { PracticeSession } from '../components/PracticeSession.tsx'
import { useDocumentTitle } from '../components/useDocumentTitle.ts'

const useStyles = makeStyles({
  viewer: { maxWidth: '720px', marginInline: 'auto', display: 'flex', flexDirection: 'column', gap: tokens.spacingVerticalL },
  empty: { padding: tokens.spacingHorizontalXL, gap: tokens.spacingVerticalM, alignItems: 'center', textAlign: 'center' },
  actions: { display: 'flex', flexWrap: 'wrap', justifyContent: 'center', gap: tokens.spacingHorizontalS },
})

/**
 * Denní opakování (BA §2.2 D) — celé, nebo jen pro předmět (?predmet=slug).
 * Seance má nejvýš 20 karet; na předmět platí denní limit, který lze výslovně překročit.
 */
export function ReviewPage() {
  const s = useStyles()
  const navigate = useNavigate()
  const [params] = useSearchParams()
  const subjectSlug = params.get('predmet') ?? undefined
  const [round, setRound] = useState(0)
  const [ignoreLimit, setIgnoreLimit] = useState(false)

  const summary = useQuery({ queryKey: ['review-summary'], queryFn: api.reviewSummary })
  const session = useQuery({
    queryKey: ['review', subjectSlug, round, ignoreLimit],
    queryFn: () => api.review({ subjectSlug, ignoreDailyLimit: ignoreLimit }),
    staleTime: Infinity,
    gcTime: 0,
    refetchOnWindowFocus: false,
  })

  const relevant = (summary.data?.subjects ?? []).filter((x) => !subjectSlug || x.slug === subjectSlug)
  const subjectName = subjectSlug ? relevant[0]?.name : undefined
  const remaining = relevant.reduce((sum, x) => sum + x.available, 0)
  const overLimit = relevant.reduce((sum, x) => sum + (x.due - x.available), 0)
  const title = subjectName ? `Opakování — ${subjectName}` : 'Dnešní opakování'
  useDocumentTitle(title)

  const nextRound = () => setRound((r) => r + 1)
  const back = () => (subjectSlug ? navigate(`/predmet/${subjectSlug}`) : navigate('/'))

  if (session.isLoading || session.error) return <PageState isLoading={session.isLoading} error={session.error} />

  if (session.data && session.data.length === 0)
    return (
      <div className={s.viewer}>
        <Title2 as="h1">{title}</Title2>
        <Card className={s.empty}>
          <CheckmarkStarburstFilled fontSize={48} color={tokens.colorPaletteGreenForeground1} />
          {overLimit > 0 && !ignoreLimit ? (
            <>
              <Text size={500} weight="semibold">Dnešní dávka je hotová</Text>
              <Body1>
                Na dnešek máš splněný limit {summary.data?.dailyLimitPerSubject} karet na předmět. Zbývajících {overLimit}{' '}
                splatných karet počká na další dny — nebo si je můžeš projít hned.
              </Body1>
              <div className={s.actions}>
                <Button appearance="primary" onClick={() => setIgnoreLimit(true)}>
                  Pokračovat i nad limit
                </Button>
                <Button onClick={back}>Zpět</Button>
              </div>
            </>
          ) : (
            <>
              <Text size={500} weight="semibold">Na dnešek nic k opakování</Text>
              <Body1>Skvělé — všechno, co máš probrané, je zatím v suchu. Můžeš se pustit do nové látky.</Body1>
              <div className={s.actions}>
                <Button onClick={back}>Zpět</Button>
              </div>
            </>
          )}
        </Card>
        <ContinueCard />
      </div>
    )

  return (
    session.data && (
      <PracticeSession
        key={`${round}-${ignoreLimit}`}
        questions={session.data}
        mode="Review"
        subjectSlug={subjectSlug}
        title={title}
        intro="Karty, které jsou podle plánu na řadě — nejdřív ty, se kterými jsi měl naposledy potíže."
        summaryActions={
          <>
            {(remaining > 0 || (ignoreLimit && overLimit > 0)) && (
              <Button appearance="primary" onClick={nextRound}>
                Další dávka
              </Button>
            )}
            <Button onClick={back}>{subjectSlug ? 'Zpět na předmět' : 'Domů'}</Button>
          </>
        }
      />
    )
  )
}

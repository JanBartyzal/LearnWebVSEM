import { useState } from 'react'
import { useQuery } from '@tanstack/react-query'
import { useNavigate, useSearchParams } from 'react-router-dom'
import { Button, MessageBar, MessageBarBody } from '@fluentui/react-components'
import { api } from '../api/client.ts'
import { PageState } from '../components/PageState.tsx'
import { PracticeSession } from '../components/PracticeSession.tsx'
import { useDocumentTitle } from '../components/useDocumentTitle.ts'

const QUIZ_LENGTH = 10

/** Procvičování nad tématem (?tema=ID), celým předmětem (?predmet=slug) nebo vybranými kartami (?karty=1,2,3 — např. chyby ze zkoušky). */
export function QuizPage() {
  const [params] = useSearchParams()
  const navigate = useNavigate()
  const topicId = params.get('tema') ? Number(params.get('tema')) : undefined
  const subjectSlug = params.get('predmet') ?? undefined
  const cardIds = params.get('karty')?.split(',').map(Number).filter((n) => Number.isInteger(n) && n > 0)
  const [attempt, setAttempt] = useState(0)
  useDocumentTitle('Procvičování')

  const { data, isLoading, error } = useQuery({
    queryKey: ['quiz', topicId, subjectSlug, cardIds?.join(','), attempt],
    queryFn: () =>
      api.quiz({ topicId, subjectSlug, cardIds, mode: 'Quiz', count: cardIds?.length ? Math.min(cardIds.length, 30) : QUIZ_LENGTH }),
    staleTime: Infinity,
    gcTime: 0,
    refetchOnWindowFocus: false,
    enabled: topicId !== undefined || subjectSlug !== undefined || !!cardIds?.length,
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
        <PracticeSession
          key={attempt}
          questions={data}
          mode="Quiz"
          subjectSlug={subjectSlug}
          topicId={topicId}
          title="Procvičování"
          intro="Přednost mají karty, se kterými jsi měl potíže, a karty k opakování."
          summaryActions={
            <>
              <Button appearance="primary" onClick={() => setAttempt((a) => a + 1)}>
                Další kvíz
              </Button>
              <Button onClick={() => (subjectSlug ? navigate(`/predmet/${subjectSlug}`) : navigate(-1))}>Zpět</Button>
            </>
          }
        />
      )}
    </>
  )
}

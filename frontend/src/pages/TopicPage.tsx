import { useCallback, useEffect, useState } from 'react'
import { useQuery } from '@tanstack/react-query'
import { useNavigate, useParams } from 'react-router-dom'
import {
  Breadcrumb,
  BreadcrumbButton,
  BreadcrumbDivider,
  BreadcrumbItem,
  Button,
  makeStyles,
  Text,
  Title2,
  tokens,
} from '@fluentui/react-components'
import { ArrowLeftRegular, ArrowRightRegular, ArrowSyncRegular } from '@fluentui/react-icons'
import { api } from '../api/client.ts'
import { FlashCard } from '../components/FlashCard.tsx'
import { ignoreShortcut } from '../components/keyboard.ts'
import { PageState } from '../components/PageState.tsx'
import { useDocumentTitle } from '../components/useDocumentTitle.ts'
import { useCrumbStyles } from '../components/crumbs.ts'

const useStyles = makeStyles({
  viewer: { maxWidth: '720px', marginInline: 'auto', marginTop: tokens.spacingVerticalL },
  nav: {
    display: 'flex',
    justifyContent: 'space-between',
    alignItems: 'center',
    gap: tokens.spacingHorizontalS,
    marginTop: tokens.spacingVerticalL,
  },
})

/** Volné prohlížení karet tématu — bez zápisu pokroku (učení s pokrokem je LearnPage). */
export function TopicPage() {
  const crumbs = useCrumbStyles()
  const s = useStyles()
  const navigate = useNavigate()
  const id = Number(useParams().id)
  const { data, isLoading, error } = useQuery({ queryKey: ['topic', id], queryFn: () => api.topic(id) })
  useDocumentTitle(data?.name)

  const [index, setIndex] = useState(0)
  const [flipped, setFlipped] = useState(false)
  const count = data?.cards.length ?? 0
  const card = data?.cards[index]

  const go = useCallback(
    (delta: number) => {
      setIndex((i) => Math.min(Math.max(i + delta, 0), Math.max(count - 1, 0)))
      setFlipped(false)
    },
    [count],
  )

  useEffect(() => {
    const onKey = (e: KeyboardEvent) => {
      if (ignoreShortcut(e)) return
      if (e.key === 'ArrowRight') go(1)
      else if (e.key === 'ArrowLeft') go(-1)
      else if (e.key === ' ' || e.key === 'Enter') {
        e.preventDefault()
        setFlipped((f) => !f)
      }
    }
    window.addEventListener('keydown', onKey)
    return () => window.removeEventListener('keydown', onKey)
  }, [go])

  return (
    <>
      <Breadcrumb className={crumbs.wrap}>
        <BreadcrumbItem>
          <BreadcrumbButton onClick={() => navigate(data ? `/?oblast=${data.areaSlug}` : '/')}>
          {data?.areaName ?? 'Předměty'}
        </BreadcrumbButton>
        </BreadcrumbItem>
        <BreadcrumbDivider />
        <BreadcrumbItem>
          <BreadcrumbButton onClick={() => data && navigate(`/predmet/${data.subjectSlug}`)}>
            {data?.subjectName ?? '…'}
          </BreadcrumbButton>
        </BreadcrumbItem>
        <BreadcrumbDivider />
        <BreadcrumbItem>
          <BreadcrumbButton current>{data?.name ?? '…'}</BreadcrumbButton>
        </BreadcrumbItem>
      </Breadcrumb>

      <PageState isLoading={isLoading} error={error} />

      {data && <Title2 as="h1">{data.name}</Title2>}
      {data && count === 0 && <Text as="p">Téma zatím nemá žádné karty.</Text>}

      {card && (
        <div className={s.viewer}>
          <FlashCard type={card.type} front={card.front} back={card.back} flipped={flipped}
            onFlip={() => setFlipped((f) => !f)} position={`${index + 1} / ${count}`} />

          <div className={s.nav}>
            <Button icon={<ArrowLeftRegular />} disabled={index === 0} onClick={() => go(-1)}>
              Předchozí
            </Button>
            {card.type === 'term' && (
              <Button appearance="subtle" icon={<ArrowSyncRegular />} onClick={() => setFlipped((f) => !f)}>
                Otočit
              </Button>
            )}
            <Button appearance="primary" icon={<ArrowRightRegular />} iconPosition="after"
              disabled={index >= count - 1} onClick={() => go(1)}>
              Další
            </Button>
          </div>
        </div>
      )}
    </>
  )
}

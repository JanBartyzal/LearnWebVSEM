import { useQuery } from '@tanstack/react-query'
import { Link, useNavigate, useParams } from 'react-router-dom'
import {
  Badge,
  Breadcrumb,
  BreadcrumbButton,
  BreadcrumbDivider,
  BreadcrumbItem,
  Button,
  Card,
  CardFooter,
  CardHeader,
  Caption1,
  makeStyles,
  Text,
  Title2,
  tokens,
} from '@fluentui/react-components'
import {
  ArrowRepeatAllRegular,
  BookOpenRegular,
  CheckmarkCircleRegular,
  ClipboardTaskListLtrRegular,
  DataBarVerticalRegular,
  QuizNewRegular,
  ReadingListRegular,
  StarRegular,
} from '@fluentui/react-icons'
import { api } from '../api/client.ts'
import { Markdown } from '../components/Markdown.tsx'
import { MasteryBar } from '../components/MasteryBar.tsx'
import { cardsWord } from '../components/plural.ts'
import { PageState } from '../components/PageState.tsx'
import { useDocumentTitle } from '../components/useDocumentTitle.ts'
import { useCrumbStyles } from '../components/crumbs.ts'

const useStyles = makeStyles({
  goal: { color: tokens.colorNeutralForeground2, maxWidth: '75ch' },
  summary: { maxWidth: '420px', marginBlock: tokens.spacingVerticalL },
  list: { display: 'flex', flexDirection: 'column', gap: tokens.spacingVerticalM },
  description: {
    color: tokens.colorNeutralForeground2,
    display: '-webkit-box',
    WebkitLineClamp: '3',
    WebkitBoxOrient: 'vertical',
    overflow: 'hidden',
  },
  footer: { alignItems: 'end', flexWrap: 'wrap' },
  mastery: { flexGrow: 1, minWidth: '180px' },
  actions: { display: 'flex', flexWrap: 'wrap', gap: tokens.spacingHorizontalS },
  badges: { display: 'flex', flexWrap: 'wrap', justifyContent: 'flex-end', gap: tokens.spacingHorizontalXS },
  summaryRow: { display: 'flex', flexWrap: 'wrap', alignItems: 'end', gap: tokens.spacingHorizontalL },
})

export function SubjectPage() {
  const crumbs = useCrumbStyles()
  const s = useStyles()
  const navigate = useNavigate()
  const { slug = '' } = useParams()
  const { data, isLoading, error } = useQuery({ queryKey: ['subject', slug], queryFn: () => api.subject(slug) })
  useDocumentTitle(data?.name)
  const reviewSummary = useQuery({ queryKey: ['review-summary'], queryFn: api.reviewSummary })
  const toReview = reviewSummary.data?.subjects.find((x) => x.slug === slug)?.available ?? 0
  // BA §2.2 B: témata se doporučují v pořadí sylabu (další se vizuálně „odemyká"), otevřít jde kterékoli.
  const recommendedId = data?.topics.find((t) => t.cardCount > 0 && t.seenCount < t.cardCount)?.id

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
          <BreadcrumbButton current>{data?.name ?? '…'}</BreadcrumbButton>
        </BreadcrumbItem>
      </Breadcrumb>

      <PageState isLoading={isLoading} error={error} />

      {data && (
        <>
          <Title2 as="h1">{data.name}</Title2>
          {/* cíl předmětu může obsahovat Markdown (např. odstavec se studijní oporou) */}
          <div className={s.goal}>
            <Markdown>{data.goal}</Markdown>
          </div>
          <div className={s.summaryRow}>
            <div className={s.summary}>
              <MasteryBar value={data.mastery} label="Zvládnutí předmětu" />
            </div>
            {toReview > 0 && (
              <Button appearance="primary" icon={<ArrowRepeatAllRegular />}
                onClick={() => navigate(`/opakovani?predmet=${data.slug}`)}>
                Opakovat ({toReview} {cardsWord(toReview)})
              </Button>
            )}
            {data.topics.some((t) => t.cardCount > 0) && (
              <>
                <Button icon={<QuizNewRegular />} onClick={() => navigate(`/procvicovani?predmet=${data.slug}`)}>
                  Procvičit celý předmět
                </Button>
                <Button icon={<ClipboardTaskListLtrRegular />} onClick={() => navigate(`/zkouska/${data.slug}`)}>
                  {data.exam ? `Zkouška nanečisto (${data.exam.questions} otázek, ${data.exam.minutes} min)` : 'Zkouška nanečisto'}
                </Button>
                <Button appearance="subtle" icon={<DataBarVerticalRegular />} onClick={() => navigate(`/statistiky?predmet=${data.slug}`)}>
                  Statistiky
                </Button>
              </>
            )}
          </div>

          <div className={s.list}>
            {data.topics.map((topic) => (
              <Card key={topic.id} appearance={topic.id === recommendedId ? 'filled-alternative' : undefined}>
                <CardHeader
                  header={
                    <Text weight="semibold" size={400}>
                      {topic.order}. {topic.name}
                    </Text>
                  }
                  action={
                    topic.cardCount > 0 ? (
                      <span className={s.badges}>
                        {topic.id === recommendedId && (
                          <Badge appearance="filled" icon={<StarRegular />}>Doporučeno</Badge>
                        )}
                        {topic.seenCount >= topic.cardCount ? (
                          <Badge appearance="tint" color="success" icon={<CheckmarkCircleRegular />}>Probráno</Badge>
                        ) : (
                          <Badge appearance="tint">
                            {topic.seenCount}/{topic.cardCount} karet
                          </Badge>
                        )}
                      </span>
                    ) : (
                      <Badge appearance="outline" color="subtle">
                        bez karet
                      </Badge>
                    )
                  }
                />
                <Caption1 className={s.description}>{topic.description}</Caption1>
                <CardFooter className={s.footer}>
                  <div className={s.mastery}>
                    <MasteryBar value={topic.mastery} />
                  </div>
                  {topic.cardCount > 0 ? (
                    <div className={s.actions}>
                      <Button appearance="subtle" icon={<ReadingListRegular />} onClick={() => navigate(`/tema/${topic.id}`)}>
                        Prohlížet
                      </Button>
                      <Button icon={<QuizNewRegular />} onClick={() => navigate(`/procvicovani?tema=${topic.id}`)}>
                        Procvičovat
                      </Button>
                      <Button appearance="primary" icon={<BookOpenRegular />} onClick={() => navigate(`/uceni/${topic.id}`)}>
                        {topic.seenCount === 0 ? 'Učit se' : topic.seenCount < topic.cardCount ? 'Pokračovat' : 'Projít znovu'}
                      </Button>
                    </div>
                  ) : (
                    <Link to="/obsah">Doplnit obsah</Link>
                  )}
                </CardFooter>
              </Card>
            ))}
          </div>
        </>
      )}
    </>
  )
}

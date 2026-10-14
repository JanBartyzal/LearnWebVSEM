import { useQuery } from '@tanstack/react-query'
import { Link, useNavigate, useParams } from 'react-router-dom'
import {
  Badge,
  Body1,
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
import { BookOpenRegular, QuizNewRegular, ReadingListRegular } from '@fluentui/react-icons'
import { api } from '../api/client.ts'
import { MasteryBar } from '../components/MasteryBar.tsx'
import { PageState } from '../components/PageState.tsx'

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
  summaryRow: { display: 'flex', flexWrap: 'wrap', alignItems: 'end', gap: tokens.spacingHorizontalL },
})

export function SubjectPage() {
  const s = useStyles()
  const navigate = useNavigate()
  const { slug = '' } = useParams()
  const { data, isLoading, error } = useQuery({ queryKey: ['subject', slug], queryFn: () => api.subject(slug) })

  return (
    <>
      <Breadcrumb>
        <BreadcrumbItem>
          <BreadcrumbButton onClick={() => navigate('/')}>Předměty</BreadcrumbButton>
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
          <Body1 as="p" className={s.goal}>
            {data.goal}
          </Body1>
          <div className={s.summaryRow}>
            <div className={s.summary}>
              <MasteryBar value={data.mastery} label="Zvládnutí předmětu" />
            </div>
            {data.topics.some((t) => t.cardCount > 0) && (
              <Button icon={<QuizNewRegular />} onClick={() => navigate(`/procvicovani?predmet=${data.slug}`)}>
                Procvičit celý předmět
              </Button>
            )}
          </div>

          <div className={s.list}>
            {data.topics.map((topic) => (
              <Card key={topic.id}>
                <CardHeader
                  header={
                    <Text weight="semibold" size={400}>
                      {topic.order}. {topic.name}
                    </Text>
                  }
                  action={
                    topic.cardCount > 0 ? (
                      <Badge appearance="tint">
                        {topic.seenCount}/{topic.cardCount} karet
                      </Badge>
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

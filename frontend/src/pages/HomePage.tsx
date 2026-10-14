import { useQuery } from '@tanstack/react-query'
import { Link, useNavigate } from 'react-router-dom'
import {
  Body1,
  Button,
  Card,
  CardHeader,
  Caption1,
  makeStyles,
  MessageBar,
  MessageBarBody,
  Text,
  Title2,
  tokens,
} from '@fluentui/react-components'
import { api } from '../api/client.ts'
import { MasteryBar } from '../components/MasteryBar.tsx'
import { PageState } from '../components/PageState.tsx'

const useStyles = makeStyles({
  grid: {
    display: 'grid',
    gridTemplateColumns: 'repeat(auto-fill, minmax(260px, 1fr))',
    gap: tokens.spacingHorizontalL,
    marginTop: tokens.spacingVerticalL,
  },
  card: { height: '100%' },
})

export function HomePage() {
  const s = useStyles()
  const navigate = useNavigate()
  const { data, isLoading, error } = useQuery({ queryKey: ['subjects'], queryFn: api.subjects })

  return (
    <>
      <Title2 as="h1">Předměty</Title2>
      <Body1 as="p">Vyber předmět a projdi jeho látku po tématech.</Body1>

      <PageState isLoading={isLoading} error={error} />

      {data?.length === 0 && (
        <MessageBar>
          <MessageBarBody>
            Zatím tu není žádný obsah. <Link to="/obsah">Nahraj ho ve Správě obsahu</Link>.
          </MessageBarBody>
        </MessageBar>
      )}

      <div className={s.grid}>
        {data?.map((subject) => (
          <Card key={subject.id} className={s.card} onClick={() => navigate(`/predmet/${subject.slug}`)}>
            <CardHeader
              header={
                <Text weight="semibold" size={400}>
                  {subject.name}
                </Text>
              }
              description={
                <Caption1>
                  {subject.topicCount} témat · {subject.cardCount} karet
                </Caption1>
              }
            />
            <MasteryBar value={subject.mastery} />
          </Card>
        ))}
      </div>

      {data && data.length > 0 && (
        <Button appearance="subtle" style={{ marginTop: tokens.spacingVerticalXL }} onClick={() => navigate('/obsah')}>
          Spravovat obsah
        </Button>
      )}
    </>
  )
}

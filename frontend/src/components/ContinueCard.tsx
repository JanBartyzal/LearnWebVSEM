import { useQuery } from '@tanstack/react-query'
import { useNavigate } from 'react-router-dom'
import { Body1, Button, Card, CardHeader, Caption1, makeStyles, Text, tokens } from '@fluentui/react-components'
import { ArrowRightRegular, PlayCircleRegular } from '@fluentui/react-icons'
import { api } from '../api/client.ts'
import { MasteryBar } from './MasteryBar.tsx'

const useStyles = makeStyles({
  card: { height: '100%', gap: tokens.spacingVerticalM },
  footer: { marginTop: 'auto' },
})

/** „Pokračovat tam, kde jsi skončil" (BA §2.2 A) — cíl určuje backend (`ContinueRule`). */
export function ContinueCard() {
  const s = useStyles()
  const navigate = useNavigate()
  const { data, isLoading } = useQuery({ queryKey: ['continue'], queryFn: api.continueInfo })
  if (isLoading) return null

  if (!data)
    return (
      <Card className={s.card}>
        <CardHeader image={<PlayCircleRegular fontSize={28} />} header={<Text weight="semibold">Začni se učit</Text>} />
        <Body1>Vyber předmět níže a projdi první téma — karty se ti pak budou samy vracet k opakování.</Body1>
      </Card>
    )

  const learn = data.kind === 'learn'
  return (
    <Card className={s.card}>
      <CardHeader
        image={<PlayCircleRegular fontSize={28} />}
        header={<Text weight="semibold">Pokračovat tam, kde jsi skončil</Text>}
        description={<Caption1>{data.subjectName}</Caption1>}
      />
      <Body1>{learn ? data.topicName : 'Všechna témata máš probraná — procvič si předmět.'}</Body1>
      {learn && (
        <MasteryBar value={data.cardCount ? data.seenCount / data.cardCount : 0}
          label={`Probráno ${data.seenCount} z ${data.cardCount} karet`} />
      )}
      <div className={s.footer}>
        <Button appearance="primary" icon={<ArrowRightRegular />} iconPosition="after"
          onClick={() => navigate(learn ? `/uceni/${data.topicId}` : `/procvicovani?predmet=${data.subjectSlug}`)}>
          {learn ? 'Pokračovat v učení' : 'Procvičovat předmět'}
        </Button>
      </div>
    </Card>
  )
}

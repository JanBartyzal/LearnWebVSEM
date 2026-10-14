import type { ReactNode } from 'react'
import { Body1, Card, makeStyles, Text, Title2, tokens } from '@fluentui/react-components'
import { TrophyFilled } from '@fluentui/react-icons'

const useStyles = makeStyles({
  card: { padding: tokens.spacingHorizontalXL, gap: tokens.spacingVerticalM, alignItems: 'center', textAlign: 'center' },
  stats: { display: 'flex', flexWrap: 'wrap', justifyContent: 'center', gap: tokens.spacingHorizontalXXL },
  stat: { display: 'flex', flexDirection: 'column', alignItems: 'center' },
  actions: { display: 'flex', flexWrap: 'wrap', justifyContent: 'center', gap: tokens.spacingHorizontalS },
})

interface Props {
  title: string
  message: string
  stats: { label: string; value: string }[]
  actions: ReactNode
  children?: ReactNode
}

/** Shrnutí na konci seance — povzbuzující, bez penalizací. */
export function SessionSummary({ title, message, stats, actions, children }: Props) {
  const s = useStyles()
  return (
    <Card className={s.card}>
      <TrophyFilled fontSize={48} color={tokens.colorPaletteMarigoldForeground1} />
      <Title2 as="h2">{title}</Title2>
      <Body1>{message}</Body1>
      <div className={s.stats}>
        {stats.map((x) => (
          <div key={x.label} className={s.stat}>
            <Text size={600} weight="semibold">
              {x.value}
            </Text>
            <Text size={200}>{x.label}</Text>
          </div>
        ))}
      </div>
      {children}
      <div className={s.actions}>{actions}</div>
    </Card>
  )
}

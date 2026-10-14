import { Badge, Caption1, Card, makeStyles, Title3, tokens } from '@fluentui/react-components'
import type { CardType } from '../api/types.ts'
import { Markdown } from './Markdown.tsx'

const cardTypeLabel: Record<CardType, string> = { term: 'Pojem', explain: 'Výklad', compare: 'Srovnání' }

const useStyles = makeStyles({
  card: { minHeight: '320px', padding: tokens.spacingHorizontalXL, gap: tokens.spacingVerticalM },
  front: { textAlign: 'center', marginBlock: 'auto' },
  meta: { display: 'flex', justifyContent: 'space-between', alignItems: 'center', gap: tokens.spacingHorizontalS },
  hint: { color: tokens.colorNeutralForeground3, textAlign: 'center', display: 'block', marginTop: tokens.spacingVerticalS },
})

interface Props {
  type: CardType
  front: string
  back: string
  /** Pojem se otáčí (líc → rub), výklad a srovnání se rovnou čtou. */
  flipped: boolean
  onFlip: () => void
  /** Text vpravo nahoře, např. „3 / 12". */
  position?: string
}

export function FlashCard({ type, front, back, flipped, onFlip, position }: Props) {
  const s = useStyles()
  const showBack = type !== 'term' || flipped

  return (
    <>
      <Card className={s.card} onClick={() => type === 'term' && onFlip()}>
        <div className={s.meta}>
          <Badge appearance="tint">{cardTypeLabel[type]}</Badge>
          {position && <Caption1>{position}</Caption1>}
        </div>
        {showBack ? (
          <>
            <Title3 as="h2">{front}</Title3>
            <Markdown>{back}</Markdown>
          </>
        ) : (
          <Title3 as="h2" className={s.front}>
            {front}
          </Title3>
        )}
      </Card>
      {!showBack && <Caption1 className={s.hint}>Klepni na kartu nebo stiskni mezerník pro otočení</Caption1>}
    </>
  )
}

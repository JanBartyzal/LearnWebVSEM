import { useRef } from 'react'
import { Badge, Caption1, Card, makeStyles, mergeClasses, Title3, tokens } from '@fluentui/react-components'
import type { CardType } from '../api/types.ts'
import { Markdown } from './Markdown.tsx'
import { useMotion } from './motion.ts'

const cardTypeLabel: Record<CardType, string> = { term: 'Pojem', explain: 'Výklad', compare: 'Srovnání' }

/** Minimální vodorovný posun prstu (px), který se počítá jako přejetí — a musí převažovat nad svislým (scroll). */
const SWIPE_MIN = 60

const useStyles = makeStyles({
  card: { minHeight: '320px', padding: tokens.spacingHorizontalXL, gap: tokens.spacingVerticalM, touchAction: 'pan-y' },
  front: { textAlign: 'center', marginBlock: 'auto' },
  meta: { display: 'flex', justifyContent: 'space-between', alignItems: 'center', gap: tokens.spacingHorizontalS },
  hint: { color: tokens.colorNeutralForeground3, textAlign: 'center', display: 'block', marginTop: tokens.spacingVerticalS },
  touchOnly: { '@media (hover: hover)': { display: 'none' } },
  pointerOnly: { '@media (hover: none)': { display: 'none' } },
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
  /** Přejetí prstem doleva (další) / doprava (zpět) — na mobilu v režimu Učení. */
  onSwipeLeft?: () => void
  onSwipeRight?: () => void
}

export function FlashCard({ type, front, back, flipped, onFlip, position, onSwipeLeft, onSwipeRight }: Props) {
  const s = useStyles()
  const motion = useMotion()
  const showBack = type !== 'term' || flipped
  const start = useRef<{ x: number; y: number } | null>(null)
  const swipeable = !!(onSwipeLeft || onSwipeRight)

  return (
    <>
      <Card
        // Nový klíč = nová karta nebo otočení → přehraje se animace odhalení.
        key={`${front}-${showBack}`}
        className={mergeClasses(s.card, motion.reveal)}
        onClick={() => type === 'term' && onFlip()}
        onTouchStart={(e) => (start.current = { x: e.touches[0].clientX, y: e.touches[0].clientY })}
        onTouchEnd={(e) => {
          const from = start.current
          start.current = null
          if (!from || !swipeable) return
          const dx = e.changedTouches[0].clientX - from.x
          const dy = e.changedTouches[0].clientY - from.y
          if (Math.abs(dx) < SWIPE_MIN || Math.abs(dx) < 1.5 * Math.abs(dy)) return
          if (dx < 0) onSwipeLeft?.()
          else onSwipeRight?.()
        }}
      >
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
      {!showBack && (
        <Caption1 className={s.hint}>
          <span className={s.pointerOnly}>Klepni na kartu nebo stiskni mezerník pro otočení</span>
          <span className={s.touchOnly}>Klepni na kartu pro otočení{swipeable ? ' · přejetím doleva pokračuješ' : ''}</span>
        </Caption1>
      )}
      {showBack && swipeable && (
        <Caption1 className={mergeClasses(s.hint, s.touchOnly)}>Přejeď doleva na další kartu, doprava zpět</Caption1>
      )}
    </>
  )
}

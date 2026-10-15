import { useEffect, useRef, useState, type ReactNode } from 'react'
import { Button, Caption1, makeStyles, Table, TableBody, TableCell, TableHeader, TableHeaderCell, TableRow, Text, tokens } from '@fluentui/react-components'
import type { ActivityDay, DailySuccess } from '../api/types.ts'

// Barvy grafů jsou tokeny tématu (ThemeProvider) — modrá × oranžová, sekvenční modrá; ověřeno validátorem palet.
const v = (name: string) => `var(--${name})`

const useStyles = makeStyles({
  wrap: { position: 'relative', display: 'flex', flexDirection: 'column', gap: tokens.spacingVerticalS },
  svg: { display: 'block', width: '100%', height: 'auto', overflow: 'visible' },
  axis: { fill: tokens.colorNeutralForeground3, fontSize: '10px' },
  grid: { stroke: tokens.colorNeutralStroke2, strokeWidth: 1 },
  cell: { outline: 'none', cursor: 'default', ':focus-visible': { stroke: tokens.colorStrokeFocus2, strokeWidth: 2 } },
  tooltip: {
    position: 'absolute',
    pointerEvents: 'none',
    transform: 'translate(-50%, calc(-100% - 8px))',
    padding: `${tokens.spacingVerticalXS} ${tokens.spacingHorizontalS}`,
    borderRadius: tokens.borderRadiusMedium,
    backgroundColor: tokens.colorNeutralBackground1,
    boxShadow: tokens.shadow8,
    color: tokens.colorNeutralForeground1,
    fontSize: tokens.fontSizeBase200,
    whiteSpace: 'nowrap',
    zIndex: 1,
  },
  legend: { display: 'flex', alignItems: 'center', flexWrap: 'wrap', gap: tokens.spacingHorizontalM, color: tokens.colorNeutralForeground2 },
  swatchRow: { display: 'flex', alignItems: 'center', gap: '3px' },
  swatch: { width: '12px', height: '12px', borderRadius: '2px', flexShrink: 0 },
  footer: { display: 'flex', justifyContent: 'space-between', alignItems: 'center', flexWrap: 'wrap', gap: tokens.spacingHorizontalS },
})

/** YYYY-MM-DD jako místní datum (ne UTC půlnoc). */
const parseLocal = (iso: string) => {
  const [y, m, d] = iso.split('-').map(Number)
  return new Date(y, m - 1, d)
}
const fmtDay = (iso: string) => {
  return parseLocal(iso).toLocaleDateString('cs-CZ', { weekday: 'short', day: 'numeric', month: 'numeric' })
}
const fmtShort = (iso: string) => {
  const [, m, d] = iso.split('-').map(Number)
  return `${d}. ${m}.`
}

interface Tip {
  x: number
  y: number
  content: ReactNode
}

/** Popisek u značky — při najetí myší i při fokusu z klávesnice; souřadnice v % šířky/výšky grafu. */
function useTooltip() {
  const [tip, setTip] = useState<Tip | null>(null)
  const bind = (x: number, y: number, content: ReactNode) => ({
    onMouseEnter: () => setTip({ x, y, content }),
    onMouseLeave: () => setTip(null),
    onFocus: () => setTip({ x, y, content }),
    onBlur: () => setTip(null),
  })
  return { tip, bind }
}

function TooltipBox({ tip }: { tip: Tip | null }) {
  const s = useStyles()
  if (!tip) return null
  return (
    // U okrajů grafu se popisek zarovná dovnitř, aby nepřetékal mimo kartu.
    <div className={s.tooltip} role="status"
      style={{ left: `${tip.x}%`, top: `${tip.y}%`, transform: `translate(${tip.x > 80 ? '-100%' : tip.x < 20 ? '0' : '-50%'}, calc(-100% - 8px))` }}>
      {tip.content}
    </div>
  )
}

function TableToggle({ shown, onToggle }: { shown: boolean; onToggle: () => void }) {
  return (
    <Button appearance="subtle" size="small" onClick={onToggle} aria-expanded={shown}>
      {shown ? 'Skrýt tabulku' : 'Zobrazit jako tabulku'}
    </Button>
  )
}

/** Šířka kontejneru v px — graf kreslí ve skutečných pixelech, takže popisky os zůstávají čitelné i na mobilu. */
function useWidth<T extends HTMLElement>(fallback: number) {
  const ref = useRef<T>(null)
  const [width, setWidth] = useState(fallback)
  useEffect(() => {
    const el = ref.current
    if (!el) return
    const ro = new ResizeObserver(([entry]) => setWidth(Math.max(280, Math.round(entry.contentRect.width))))
    ro.observe(el)
    return () => ro.disconnect()
  }, [])
  return [ref, width] as const
}

// ---------- Kalendář aktivity ----------

/** Úroveň aktivity dne 0–4 (odpovědi + nově probrané karty). */
function activityLevel(day: ActivityDay) {
  const n = day.answers + day.learned
  return n === 0 ? 0 : n < 10 ? 1 : n < 25 ? 2 : n < 50 ? 3 : 4
}
const LEVEL_FILL = [tokens.colorNeutralBackground3, v('chartSeq1'), v('chartSeq2'), v('chartSeq3'), v('chartSeq4')]
const LEVEL_TEXT = ['žádná aktivita', '1–9', '10–24', '25–49', '50 a více']

const CELL = 14
const GAP = 3
const LEFT = 22
const TOP = 16

/** Kalendář posledních týdnů (sloupec = týden po–ne), barva = množství práce, tečka = den se dokončenou seancí. */
export function ActivityCalendar({ days }: { days: ActivityDay[] }) {
  const s = useStyles()
  const { tip, bind } = useTooltip()
  const [table, setTable] = useState(false)
  if (days.length === 0) return null

  const first = parseLocal(days[0].date)
  const offset = (first.getDay() + 6) % 7 // pondělí = 0
  const weeks = Math.ceil((days.length + offset) / 7)
  const width = LEFT + weeks * (CELL + GAP)
  const height = TOP + 7 * (CELL + GAP)

  const cells = days.map((d, i) => {
    const pos = i + offset
    return { d, col: Math.floor(pos / 7), row: pos % 7 }
  })
  // Popisek měsíce nad prvním týdnem, ve kterém měsíc začíná (podle pondělí / prvního dne sloupce).
  const monthLabels: [string, number][] = []
  for (let col = 0; col < weeks; col++) {
    const ym = cells.find((c) => c.col === col)?.d.date.slice(0, 7)
    if (ym && monthLabels.at(-1)?.[0] !== ym) monthLabels.push([ym, col])
  }

  return (
    <div className={s.wrap}>
      <svg className={s.svg} viewBox={`0 0 ${width} ${height}`} role="img"
        aria-label={`Kalendář aktivity za posledních ${days.length} dní`} style={{ maxWidth: `${width * 2}px` }}>
        {monthLabels.map(([ym, col]) => (
          <text key={ym} className={s.axis} x={LEFT + col * (CELL + GAP)} y={10}>
            {parseLocal(`${ym}-01`).toLocaleDateString('cs-CZ', { month: 'short' })}
          </text>
        ))}
        {['Po', 'St', 'Pá'].map((label, i) => (
          <text key={label} className={s.axis} x={0} y={TOP + i * 2 * (CELL + GAP) + CELL - 3}>
            {label}
          </text>
        ))}
        {cells.map(({ d, col, row }) => {
          const x = LEFT + col * (CELL + GAP)
          const y = TOP + row * (CELL + GAP)
          const level = activityLevel(d)
          const label = `${fmtDay(d.date)}: ${d.answers} odpovědí, ${d.learned} nových karet, ${d.sessions} dokončených seancí`
          return (
            <g key={d.date}>
              <rect className={s.cell} x={x} y={y} width={CELL} height={CELL} rx={3} fill={LEVEL_FILL[level]}
                tabIndex={0} aria-label={label}
                {...bind((100 * (x + CELL / 2)) / width, (100 * y) / height,
                  <>
                    <Text weight="semibold">{fmtDay(d.date)}</Text>
                    <div>{d.answers} odpovědí · {d.learned} nových karet</div>
                    <div>{d.sessions ? `${d.sessions} dokončených seancí — počítá se do série` : 'bez dokončené seance'}</div>
                  </>)} />
              {d.sessions > 0 && (
                <circle cx={x + CELL / 2} cy={y + CELL / 2} r={2} pointerEvents="none"
                  fill={level >= 3 ? tokens.colorNeutralForegroundOnBrand : tokens.colorNeutralForeground1} />
              )}
            </g>
          )
        })}
      </svg>
      <TooltipBox tip={tip} />
      <div className={s.footer}>
        <div className={s.legend}>
          <Caption1>Méně</Caption1>
          <span className={s.swatchRow} aria-hidden>
            {LEVEL_FILL.map((fill, i) => (
              <span key={i} className={s.swatch} style={{ backgroundColor: fill }} title={LEVEL_TEXT[i]} />
            ))}
          </span>
          <Caption1>Více (odpovědi + nové karty)</Caption1>
          <Caption1>· tečka = den s dokončenou seancí</Caption1>
        </div>
        <TableToggle shown={table} onToggle={() => setTable((t) => !t)} />
      </div>
      {table && (
        <Table size="small" aria-label="Aktivita po dnech">
          <TableHeader>
            <TableRow>
              <TableHeaderCell>Den</TableHeaderCell>
              <TableHeaderCell>Odpovědi</TableHeaderCell>
              <TableHeaderCell>Nové karty</TableHeaderCell>
              <TableHeaderCell>Seance</TableHeaderCell>
            </TableRow>
          </TableHeader>
          <TableBody>
            {days.filter((d) => d.answers || d.learned || d.sessions).reverse().map((d) => (
              <TableRow key={d.date}>
                <TableCell>{fmtDay(d.date)}</TableCell>
                <TableCell>{d.answers}</TableCell>
                <TableCell>{d.learned}</TableCell>
                <TableCell>{d.sessions}</TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      )}
    </div>
  )
}

// ---------- Denní odpovědi (správně × chybně) ----------

/** Obdélník se zaoblenými jen horními rohy (konec dat), dole rovně na základně. */
function topRounded(x: number, y: number, w: number, h: number, r: number) {
  const rr = Math.min(r, w / 2, h)
  return `M${x},${y + h}V${y + rr}Q${x},${y} ${x + rr},${y}H${x + w - rr}Q${x + w},${y} ${x + w},${y + rr}V${y + h}Z`
}

function niceMax(n: number) {
  if (n <= 5) return 5
  const step = 10 ** Math.floor(Math.log10(n))
  return Math.ceil(n / step) * step
}

/** Sloupce po dnech: dole správně, nad mezerou chybně. Jedna osa (počet odpovědí). */
export function DailyAnswersChart({ days }: { days: DailySuccess[] }) {
  const s = useStyles()
  const { tip, bind } = useTooltip()
  const [table, setTable] = useState(false)
  const [wrapRef, W] = useWidth<HTMLDivElement>(600)

  const H = 180
  const padL = 28
  const padB = 20
  const padT = 8
  const plotW = W - padL
  const plotH = H - padB - padT
  const max = niceMax(Math.max(1, ...days.map((d) => d.answered)))
  const slot = plotW / days.length
  const barW = Math.max(4, slot - 4)
  const y = (n: number) => padT + plotH - (n / max) * plotH

  return (
    <div className={s.wrap} ref={wrapRef}>
      <svg className={s.svg} viewBox={`0 0 ${W} ${H}`} role="img"
        aria-label={`Odpovědi za posledních ${days.length} dní, rozdělené na správné a chybné`}>
        {[0, max / 2, max].map((t) => (
          <g key={t}>
            <line className={s.grid} x1={padL} x2={W} y1={y(t)} y2={y(t)} />
            <text className={s.axis} x={padL - 6} y={y(t) + 3} textAnchor="end">{t}</text>
          </g>
        ))}
        {days.map((d, i) => {
          const x = padL + i * slot + (slot - barW) / 2
          const wrong = d.answered - d.correct
          const hCorrect = (d.correct / max) * plotH
          const hWrong = (wrong / max) * plotH
          const base = padT + plotH
          const pct = d.answered ? Math.round((100 * d.correct) / d.answered) : 0
          const label = d.answered
            ? `${fmtDay(d.date)}: ${d.answered} odpovědí, správně ${d.correct} (${pct} %), chybně ${wrong}`
            : `${fmtDay(d.date)}: bez odpovědí`
          return (
            <g key={d.date}>
              {/* Zásah větší než značka: celý sloupec dne */}
              <rect className={s.cell} x={padL + i * slot} y={padT} width={slot} height={plotH} fill="transparent"
                tabIndex={d.answered ? 0 : -1} aria-label={label}
                {...bind((100 * (x + barW / 2)) / W, (100 * y(d.answered)) / H,
                  <>
                    <Text weight="semibold">{fmtDay(d.date)}</Text>
                    <div>{d.answered ? `${d.answered} odpovědí · úspěšnost ${pct} %` : 'bez odpovědí'}</div>
                    {d.answered > 0 && <div>správně {d.correct} · chybně {wrong}</div>}
                  </>)} />
              {d.correct > 0 && (
                <path pointerEvents="none" fill={v('chartCorrect')}
                  d={wrong > 0 ? `M${x},${base}V${base - hCorrect}H${x + barW}V${base}Z` : topRounded(x, base - hCorrect, barW, hCorrect, 4)} />
              )}
              {wrong > 0 && (
                <path pointerEvents="none" fill={v('chartWrong')}
                  d={topRounded(x, base - hCorrect - hWrong, barW, Math.max(1, hWrong - (d.correct > 0 ? 2 : 0)), 4)} />
              )}
              {i % (W < 480 ? 10 : 7) === (days.length - 1) % (W < 480 ? 10 : 7) && (
                <text className={s.axis} x={i === days.length - 1 ? x + barW : x + barW / 2} y={H - 4}
                  textAnchor={i === days.length - 1 ? 'end' : 'middle'}>{fmtShort(d.date)}</text>
              )}
            </g>
          )
        })}
      </svg>
      <TooltipBox tip={tip} />
      <div className={s.footer}>
        <div className={s.legend}>
          <span className={s.swatchRow}><span className={s.swatch} style={{ backgroundColor: v('chartCorrect') }} /><Caption1>Správně</Caption1></span>
          <span className={s.swatchRow}><span className={s.swatch} style={{ backgroundColor: v('chartWrong') }} /><Caption1>Chybně</Caption1></span>
        </div>
        <TableToggle shown={table} onToggle={() => setTable((t) => !t)} />
      </div>
      {table && (
        <Table size="small" aria-label="Odpovědi po dnech">
          <TableHeader>
            <TableRow>
              <TableHeaderCell>Den</TableHeaderCell>
              <TableHeaderCell>Odpovědi</TableHeaderCell>
              <TableHeaderCell>Správně</TableHeaderCell>
              <TableHeaderCell>Úspěšnost</TableHeaderCell>
            </TableRow>
          </TableHeader>
          <TableBody>
            {days.filter((d) => d.answered).reverse().map((d) => (
              <TableRow key={d.date}>
                <TableCell>{fmtDay(d.date)}</TableCell>
                <TableCell>{d.answered}</TableCell>
                <TableCell>{d.correct}</TableCell>
                <TableCell>{Math.round((100 * d.correct) / d.answered)} %</TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      )}
    </div>
  )
}

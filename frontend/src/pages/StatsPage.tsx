import { useQuery } from '@tanstack/react-query'
import { Link, useSearchParams } from 'react-router-dom'
import {
  Body1,
  Caption1,
  Card,
  CardHeader,
  Dropdown,
  Field,
  makeStyles,
  Option,
  OptionGroup,
  Table,
  TableBody,
  TableCell,
  TableHeader,
  TableHeaderCell,
  TableRow,
  Text,
  Title2,
  Title3,
  tokens,
} from '@fluentui/react-components'
import { LockClosedRegular, TrophyFilled } from '@fluentui/react-icons'
import { api } from '../api/client.ts'
import { ActivityCalendar, DailyAnswersChart } from '../components/charts.tsx'
import { MasteryBar } from '../components/MasteryBar.tsx'
import { PageState } from '../components/PageState.tsx'
import { plural } from '../components/plural.ts'
import { useDocumentTitle } from '../components/useDocumentTitle.ts'

const useStyles = makeStyles({
  page: { display: 'flex', flexDirection: 'column', gap: tokens.spacingVerticalXL },
  tiles: { display: 'grid', gridTemplateColumns: 'repeat(auto-fill, minmax(160px, 1fr))', gap: tokens.spacingHorizontalM },
  tile: { padding: tokens.spacingHorizontalL, gap: tokens.spacingVerticalXXS },
  section: { padding: tokens.spacingHorizontalL, gap: tokens.spacingVerticalM },
  badges: { display: 'grid', gridTemplateColumns: 'repeat(auto-fill, minmax(220px, 1fr))', gap: tokens.spacingHorizontalM },
  locked: { opacity: 0.7 },
  topics: { display: 'flex', flexDirection: 'column', gap: tokens.spacingVerticalS },
  picker: { maxWidth: '360px' },
})

function Tile({ label, value, note }: { label: string; value: string; note?: string }) {
  const s = useStyles()
  return (
    <Card className={s.tile}>
      <Caption1>{label}</Caption1>
      <Text size={700} weight="semibold">{value}</Text>
      {note && <Caption1>{note}</Caption1>}
    </Card>
  )
}

const days = (n: number) => `${n} ${plural(n, 'den', 'dny', 'dní')}`

/** Statistiky a pokrok (BA §2.2 F): globálně série, kalendář, XP a odznaky; na předmět témata, úspěšnost a chyby. */
export function StatsPage() {
  const s = useStyles()
  const [params, setParams] = useSearchParams()
  const overview = useQuery({ queryKey: ['stats-overview'], queryFn: api.statsOverview })
  useDocumentTitle('Statistiky')
  const subjects = useQuery({ queryKey: ['subjects'], queryFn: api.subjects })
  const areas = useQuery({ queryKey: ['areas'], queryFn: api.areas })
  const continueInfo = useQuery({ queryKey: ['continue'], queryFn: api.continueInfo })

  const slug = params.get('predmet') ?? continueInfo.data?.subjectSlug ?? subjects.data?.[0]?.slug
  const subject = useQuery({
    queryKey: ['subject-stats', slug],
    queryFn: () => api.subjectStats(slug ?? ''),
    enabled: !!slug,
  })

  const o = overview.data
  const accuracy = o && o.answers ? Math.round((100 * o.correctAnswers) / o.answers) : 0

  return (
    <div className={s.page}>
      <Title2 as="h1">Statistiky</Title2>
      <PageState isLoading={overview.isLoading} error={overview.error} />

      {o && (
        <>
          <div className={s.tiles}>
            <Tile label="Série" value={days(o.streak.current)}
              note={o.streak.activeToday ? 'Dnes splněno' : o.streak.current ? 'Dnes ještě nic — ať série nepadne' : `Nejdelší: ${days(o.streak.longest)}`} />
            <Tile label="Nejdelší série" value={days(o.streak.longest)} />
            <Tile label={`Úroveň ${o.level}`} value={`${o.xp} XP`} note={`Do další úrovně ${o.nextLevelXp - o.xp} XP`} />
            <Tile label="Probrané karty" value={`${o.cardsSeen}`} note={`z ${o.cardsTotal}`} />
            <Tile label="Úspěšnost odpovědí" value={o.answers ? `${accuracy} %` : '—'} note={`${o.answers} odpovědí`} />
            <Tile label="Zkoušky nanečisto" value={String(o.exams)} />
          </div>

          <Card className={s.section}>
            <CardHeader header={<Title3 as="h2">Aktivita</Title3>}
              description={<Caption1>Den se do série počítá, když v něm dokončíš aspoň jednu seanci.</Caption1>} />
            <ActivityCalendar days={o.calendar} />
          </Card>

          <Card className={s.section}>
            <CardHeader header={<Title3 as="h2">Odznaky</Title3>}
              description={<Caption1>Získáno {o.badges.filter((b) => b.earned).length} z {o.badges.length}</Caption1>} />
            <div className={s.badges}>
              {o.badges.map((b) => (
                <Card key={b.code} appearance={b.earned ? 'filled' : 'outline'} className={b.earned ? undefined : s.locked}>
                  <CardHeader
                    image={b.earned
                      ? <TrophyFilled fontSize={28} color={tokens.colorPaletteMarigoldForeground1} />
                      : <LockClosedRegular fontSize={28} />}
                    header={<Text weight="semibold">{b.name}</Text>}
                    description={<Caption1>{b.earned ? 'Získáno' : 'Zatím nezískáno'} · {b.description}</Caption1>}
                  />
                </Card>
              ))}
            </div>
          </Card>
        </>
      )}

      <Card className={s.section}>
        <CardHeader header={<Title3 as="h2">Předmět</Title3>} />
        {subjects.data && slug && (
          <Field label="Vyber předmět" className={s.picker}>
            <Dropdown value={subjects.data.find((x) => x.slug === slug)?.name ?? ''} selectedOptions={[slug]}
              onOptionSelect={(_, d) => d.optionValue && setParams({ predmet: d.optionValue })}>
              {(areas.data ?? []).map((a) => (
                <OptionGroup key={a.slug} label={a.name}>
                  {subjects.data.filter((x) => x.areaSlug === a.slug).map((x) => <Option key={x.slug} value={x.slug}>{x.name}</Option>)}
                </OptionGroup>
              ))}
            </Dropdown>
          </Field>
        )}
        <PageState isLoading={subject.isLoading} error={subject.error} />
        {subject.data && (
          <>
            <MasteryBar value={subject.data.mastery} label="Zvládnutí předmětu" />

            <Text weight="semibold">Zvládnutí po tématech</Text>
            <div className={s.topics}>
              {subject.data.topics.map((t) => (
                <MasteryBar key={t.topicId} value={t.mastery}
                  label={`${t.order}. ${t.name} (probráno ${t.seenCount}/${t.cardCount})`} />
              ))}
            </div>

            <Text weight="semibold">Odpovědi za posledních 30 dní</Text>
            {subject.data.daily.some((d) => d.answered) ? (
              <DailyAnswersChart days={subject.data.daily} />
            ) : (
              <Body1>V posledních 30 dnech tu zatím nejsou žádné odpovědi.</Body1>
            )}

            <Text weight="semibold">Nejčastěji chybované karty</Text>
            {subject.data.mostMissed.length ? (
              <Table size="small" aria-label="Nejčastěji chybované karty">
                <TableHeader>
                  <TableRow>
                    <TableHeaderCell>Karta</TableHeaderCell>
                    <TableHeaderCell>Téma</TableHeaderCell>
                    <TableHeaderCell>Chyby / pokusy</TableHeaderCell>
                    <TableHeaderCell>Krabice</TableHeaderCell>
                  </TableRow>
                </TableHeader>
                <TableBody>
                  {subject.data.mostMissed.map((m) => (
                    <TableRow key={m.cardId}>
                      <TableCell>{m.front}</TableCell>
                      <TableCell><Link to={`/tema/${m.topicId}`}>{m.topicName}</Link></TableCell>
                      <TableCell>{m.wrong} / {m.attempts}</TableCell>
                      <TableCell>{m.box}</TableCell>
                    </TableRow>
                  ))}
                </TableBody>
              </Table>
            ) : (
              <Body1>Zatím žádné chyby — nebo jsi tu ještě neodpovídal.</Body1>
            )}

            <Text weight="semibold">Zkoušky nanečisto</Text>
            {subject.data.exams.length ? (
              <Table size="small" aria-label="Historie zkoušek nanečisto">
                <TableHeader>
                  <TableRow>
                    <TableHeaderCell>Kdy</TableHeaderCell>
                    <TableHeaderCell>Výsledek</TableHeaderCell>
                    <TableHeaderCell>Úspěšnost</TableHeaderCell>
                  </TableRow>
                </TableHeader>
                <TableBody>
                  {subject.data.exams.map((e) => (
                    <TableRow key={e.id}>
                      <TableCell>{new Date(e.finishedAt).toLocaleString('cs-CZ', { dateStyle: 'medium', timeStyle: 'short' })}</TableCell>
                      <TableCell>{e.score} / {e.total}</TableCell>
                      <TableCell>{e.percent} %{e.percent >= subject.data.examPassPercent ? ' — u zkoušky bys prošel' : ''}</TableCell>
                    </TableRow>
                  ))}
                </TableBody>
              </Table>
            ) : (
              <Body1>Ještě jsi nezkoušel zkoušku nanečisto. <Link to={`/zkouska/${subject.data.slug}`}>Zkusit teď</Link></Body1>
            )}
          </>
        )}
      </Card>
    </div>
  )
}

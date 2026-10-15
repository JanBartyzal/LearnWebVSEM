import { useQuery } from '@tanstack/react-query'
import { Link, useNavigate, useSearchParams } from 'react-router-dom'
import {
  Body1,
  Button,
  Card,
  CardHeader,
  Caption1,
  makeStyles,
  MessageBar,
  MessageBarBody,
  Tab,
  TabList,
  Text,
  Title2,
  tokens,
} from '@fluentui/react-components'
import { ArrowRepeatAllRegular } from '@fluentui/react-icons'
import { api } from '../api/client.ts'
import { ContinueCard } from '../components/ContinueCard.tsx'
import { InstallButton } from '../components/pwa.tsx'
import { Markdown } from '../components/Markdown.tsx'
import { MasteryBar } from '../components/MasteryBar.tsx'
import { cardsWord } from '../components/plural.ts'
import { PageState } from '../components/PageState.tsx'
import { useDocumentTitle } from '../components/useDocumentTitle.ts'

const useStyles = makeStyles({
  grid: {
    display: 'grid',
    gridTemplateColumns: 'repeat(auto-fill, minmax(260px, 1fr))',
    gap: tokens.spacingHorizontalL,
    marginTop: tokens.spacingVerticalL,
  },
  card: { height: '100%' },
  cta: {
    display: 'grid',
    gridTemplateColumns: 'repeat(auto-fit, minmax(280px, 1fr))',
    gap: tokens.spacingHorizontalL,
    marginBottom: tokens.spacingVerticalXXL,
  },
  ctaCard: { height: '100%', gap: tokens.spacingVerticalM },
  ctaFooter: { marginTop: 'auto' },
  tabs: { marginBottom: tokens.spacingVerticalL, overflowX: 'auto' },
  areaText: { color: tokens.colorNeutralForeground2, maxWidth: '75ch' },
})

/** „Dnešní opakování (N karet)" — N je součet karet, které jsou dnes na řadě v rámci denních limitů. */
function ReviewCard() {
  const s = useStyles()
  const navigate = useNavigate()
  const { data } = useQuery({ queryKey: ['review-summary'], queryFn: api.reviewSummary })
  if (!data) return null

  const waiting = data.subjects.filter((x) => x.available > 0)
  return (
    <Card className={s.ctaCard}>
      <CardHeader
        image={<ArrowRepeatAllRegular fontSize={28} />}
        header={<Text weight="semibold">Dnešní opakování ({data.total} {cardsWord(data.total)})</Text>}
        description={<Caption1>{waiting.length ? waiting.map((x) => x.name).join(' · ') : 'Fronta je prázdná'}</Caption1>}
      />
      <Body1>
        {data.total > 0
          ? 'Karty, které jsou podle plánu na řadě, a ty, se kterými jsi měl naposledy potíže.'
          : 'Na dnešek máš hotovo. Probrané karty se ti vrátí, až přijde jejich čas.'}
      </Body1>
      {data.total > 0 && (
        <div className={s.ctaFooter}>
          <Button appearance="primary" icon={<ArrowRepeatAllRegular />} onClick={() => navigate('/opakovani')}>
            Opakovat
          </Button>
        </div>
      )}
    </Card>
  )
}

const AREA_KEY = 'learnweb.area'

/** Poslední zvolená oblast (jen pohodlí — při blokovaném úložišti se použije první oblast). */
function rememberedArea() {
  try {
    return localStorage.getItem(AREA_KEY) ?? undefined
  } catch {
    return undefined
  }
}

export function HomePage() {
  const s = useStyles()
  const navigate = useNavigate()
  const [params, setParams] = useSearchParams()
  const areas = useQuery({ queryKey: ['areas'], queryFn: api.areas })
  const { data, isLoading, error } = useQuery({ queryKey: ['subjects'], queryFn: api.subjects })

  const wanted = params.get('oblast') ?? rememberedArea()
  const area = areas.data?.find((a) => a.slug === wanted) ?? areas.data?.[0]
  const subjects = data?.filter((x) => x.areaSlug === area?.slug)
  useDocumentTitle(area?.name ?? 'Předměty')

  const selectArea = (slug: string) => {
    setParams({ oblast: slug }, { replace: true })
    try {
      localStorage.setItem(AREA_KEY, slug)
    } catch {
      /* úložiště nedostupné — výběr platí jen pro tuto stránku */
    }
  }

  return (
    <>
      {data && data.length > 0 && (
        <div className={s.cta}>
          <ContinueCard />
          <ReviewCard />
        </div>
      )}

      {areas.data && areas.data.length > 1 && (
        <TabList className={s.tabs} selectedValue={area?.slug} onTabSelect={(_, d) => selectArea(String(d.value))}
          aria-label="Oblasti">
          {areas.data.map((a) => (
            <Tab key={a.slug} value={a.slug}>
              {a.name}
            </Tab>
          ))}
        </TabList>
      )}

      <Title2 as="h1" block>{area?.slug === 'vsem' || !area ? 'Předměty' : `${area.name} — kurzy`}</Title2>
      {area?.description ? (
        <div className={s.areaText}>
          <Markdown>{area.description}</Markdown>
        </div>
      ) : (
        <Body1 as="p" block>Vyber předmět a projdi jeho látku po tématech.</Body1>
      )}

      <PageState isLoading={isLoading || areas.isLoading} error={error ?? areas.error} />

      {data?.length === 0 && (
        <MessageBar>
          <MessageBarBody>
            Zatím tu není žádný obsah. <Link to="/obsah">Nahraj ho ve Správě obsahu</Link>.
          </MessageBarBody>
        </MessageBar>
      )}
      {data && data.length > 0 && subjects?.length === 0 && (
        <MessageBar>
          <MessageBarBody>V této oblasti zatím nejsou žádné kurzy.</MessageBarBody>
        </MessageBar>
      )}

      <div className={s.grid}>
        {subjects?.map((subject) => (
          <Card key={subject.id} className={s.card} onClick={() => navigate(`/predmet/${subject.slug}`)}>
            <CardHeader
              header={
                <Text weight="semibold" size={400}>
                  {subject.name}
                </Text>
              }
              description={
                <Caption1>
                  {subject.topicCount} témat · {subject.cardCount ? `${subject.cardCount} karet` : 'karty se připravují'}
                </Caption1>
              }
            />
            <MasteryBar value={subject.mastery} />
          </Card>
        ))}
      </div>

      {data && data.length > 0 && (
        <div style={{ display: 'flex', flexWrap: 'wrap', gap: tokens.spacingHorizontalS, marginTop: tokens.spacingVerticalXL }}>
          <Button appearance="subtle" onClick={() => navigate('/obsah')}>
            Spravovat obsah
          </Button>
          <InstallButton />
        </div>
      )}
    </>
  )
}

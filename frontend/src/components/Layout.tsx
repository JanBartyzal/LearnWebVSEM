import { useEffect } from 'react'
import { NavLink, Outlet, useLocation } from 'react-router-dom'
import { useQuery } from '@tanstack/react-query'
import { Badge, CounterBadge, makeStyles, mergeClasses, Text, Toaster, tokens, Tooltip } from '@fluentui/react-components'
import { api } from '../api/client.ts'
import {
  ArrowRepeatAllRegular,
  BookOpenRegular,
  DataBarVerticalRegular,
  DocumentArrowUpRegular,
  FireRegular,
  HatGraduationFilled,
} from '@fluentui/react-icons'
import { APP_TOASTER } from './achievements.tsx'
import { OfflineNotice } from './pwa.tsx'
import { cardsWord, plural } from './plural.ts'

const useStyles = makeStyles({
  header: {
    position: 'sticky',
    top: 0,
    zIndex: 10,
    display: 'flex',
    alignItems: 'center',
    gap: tokens.spacingHorizontalL,
    paddingInline: tokens.spacingHorizontalL,
    paddingBlock: tokens.spacingVerticalS,
    backgroundColor: tokens.colorNeutralBackground1,
    borderBottom: `1px solid ${tokens.colorNeutralStroke2}`,
    '@media (max-width: 480px)': { gap: tokens.spacingHorizontalS, paddingInline: tokens.spacingHorizontalM },
  },
  brand: {
    display: 'flex',
    alignItems: 'center',
    gap: tokens.spacingHorizontalS,
    color: tokens.colorBrandForeground1,
    textDecoration: 'none',
    marginRight: 'auto',
  },
  nav: { display: 'flex', gap: tokens.spacingHorizontalXS },
  link: {
    display: 'flex',
    alignItems: 'center',
    gap: tokens.spacingHorizontalXS,
    paddingInline: tokens.spacingHorizontalM,
    paddingBlock: tokens.spacingVerticalXS,
    borderRadius: tokens.borderRadiusMedium,
    color: tokens.colorNeutralForeground2,
    textDecoration: 'none',
    ':hover': { backgroundColor: tokens.colorNeutralBackground1Hover },
    '@media (max-width: 480px)': { paddingInline: tokens.spacingHorizontalS },
  },
  active: {
    color: tokens.colorBrandForeground1,
    backgroundColor: tokens.colorBrandBackground2,
  },
  main: {
    maxWidth: '1100px',
    marginInline: 'auto',
    paddingInline: tokens.spacingHorizontalL,
    paddingBlock: tokens.spacingVerticalXL,
  },
  hideOnMobile: { '@media (max-width: 480px)': { display: 'none' } },
  badge: { whiteSpace: 'nowrap', flexShrink: 0 },
})

/** Počet karet k dnešnímu opakování u odkazu v hlavičce (číslo i text — ne jen barva). */
function ReviewCount() {
  const { data } = useQuery({ queryKey: ['review-summary'], queryFn: api.reviewSummary })
  if (!data?.total) return null
  return (
    <CounterBadge count={data.total} size="small" overflowCount={99}
      aria-label={`${data.total} ${cardsWord(data.total)} k opakování`} />
  )
}

function XpBadge() {
  const s = useStyles()
  const { data } = useQuery({ queryKey: ['stats'], queryFn: api.stats })
  if (!data) return null
  const toNext = data.nextLevelXp - data.xp
  const streak = data.streak.current
  return (
    <>
      {streak > 0 && (
        <Tooltip content={data.streak.activeToday ? 'Dnes splněno' : 'Dnes ještě nic — dokonči seanci, ať série nepadne'}
          relationship="description">
          <Badge className={s.badge} appearance="tint" size="large" color={data.streak.activeToday ? 'warning' : 'subtle'}
            icon={<FireRegular />} aria-label={`Série ${streak} ${plural(streak, 'den', 'dny', 'dní')}`}>
            {streak} {plural(streak, 'den', 'dny', 'dní')}
          </Badge>
        </Tooltip>
      )}
      <Tooltip content={`Do další úrovně zbývá ${toNext} XP`} relationship="description">
        <Badge className={s.badge} appearance="tint" size="large" aria-label={`Úroveň ${data.level}, ${data.xp} XP`}>
          <span className={s.hideOnMobile}>Úr. {data.level} ·&nbsp;</span>{data.xp} XP
        </Badge>
      </Tooltip>
    </>
  )
}

export function Layout() {
  const s = useStyles()
  const { pathname } = useLocation()

  // Nová stránka začíná nahoře (SPA jinak drží posun z předchozí stránky).
  useEffect(() => {
    window.scrollTo({ top: 0 })
  }, [pathname])
  const linkClass = ({ isActive }: { isActive: boolean }) => mergeClasses(s.link, isActive && s.active)

  return (
    <>
      <header className={s.header}>
        <NavLink to="/" className={s.brand}>
          <HatGraduationFilled fontSize={28} />
          <Text weight="semibold" size={500} className={s.hideOnMobile}>
            LearnWeb
          </Text>
        </NavLink>
        <XpBadge />
        <nav className={s.nav}>
          <NavLink to="/" end className={linkClass} aria-label="Předměty">
            <BookOpenRegular />
            <span className={s.hideOnMobile}>Předměty</span>
          </NavLink>
          <NavLink to="/opakovani" className={linkClass} aria-label="Opakování">
            <ArrowRepeatAllRegular />
            <span className={s.hideOnMobile}>Opakování</span>
            <ReviewCount />
          </NavLink>
          <NavLink to="/statistiky" className={linkClass} aria-label="Statistiky">
            <DataBarVerticalRegular />
            <span className={s.hideOnMobile}>Statistiky</span>
          </NavLink>
          {/* Správa obsahu je na mobilu dostupná tlačítkem na domovské stránce. */}
          <NavLink to="/obsah" className={(a) => mergeClasses(linkClass(a), s.hideOnMobile)} aria-label="Správa obsahu">
            <DocumentArrowUpRegular />
            <span className={s.hideOnMobile}>Správa obsahu</span>
          </NavLink>
        </nav>
      </header>
      <main className={s.main}>
        <OfflineNotice />
        <Outlet />
      </main>
      <Toaster toasterId={APP_TOASTER} position="top-end" />
    </>
  )
}

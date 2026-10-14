import { NavLink, Outlet } from 'react-router-dom'
import { useQuery } from '@tanstack/react-query'
import { Badge, makeStyles, mergeClasses, Text, tokens, Tooltip } from '@fluentui/react-components'
import { api } from '../api/client.ts'
import { BookOpenRegular, DocumentArrowUpRegular, HatGraduationFilled } from '@fluentui/react-icons'

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
})

function XpBadge() {
  const { data } = useQuery({ queryKey: ['stats'], queryFn: api.stats })
  if (!data) return null
  const toNext = data.nextLevelXp - data.xp
  return (
    <Tooltip content={`Do další úrovně zbývá ${toNext} XP`} relationship="description">
      <Badge appearance="tint" size="large">
        Úr. {data.level} · {data.xp} XP
      </Badge>
    </Tooltip>
  )
}

export function Layout() {
  const s = useStyles()
  const linkClass = ({ isActive }: { isActive: boolean }) => mergeClasses(s.link, isActive && s.active)

  return (
    <>
      <header className={s.header}>
        <NavLink to="/" className={s.brand}>
          <HatGraduationFilled fontSize={28} />
          <Text weight="semibold" size={500}>
            LearnWeb
          </Text>
        </NavLink>
        <XpBadge />
        <nav className={s.nav}>
          <NavLink to="/" end className={linkClass}>
            <BookOpenRegular />
            <span>Předměty</span>
          </NavLink>
          <NavLink to="/obsah" className={linkClass}>
            <DocumentArrowUpRegular />
            <span className={s.hideOnMobile}>Správa obsahu</span>
          </NavLink>
        </nav>
      </header>
      <main className={s.main}>
        <Outlet />
      </main>
    </>
  )
}

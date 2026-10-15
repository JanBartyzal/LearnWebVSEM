import { useEffect, useState, type ReactNode } from 'react'
import { FluentProvider, webDarkTheme, webLightTheme } from '@fluentui/react-components'

const query = '(prefers-color-scheme: dark)'

/**
 * Barvy grafů jako další tokeny tématu — FluentProvider je vypíše jako CSS proměnné (`var(--chartCorrect)` …).
 * Dvojice správně/chybně je modrá × oranžová (ne zelená × červená kvůli barvoslepým), ověřená validátorem
 * palet zvlášť pro světlý a tmavý povrch. Kalendář používá jednu sekvenční modrou škálu (málo → hodně).
 */
const chartLight = {
  chartCorrect: '#0f6cbd',
  chartWrong: '#da3b01',
  chartSeq1: '#cfe4fa',
  chartSeq2: '#96c6fa',
  chartSeq3: '#479ef5',
  chartSeq4: '#0f6cbd',
}
const chartDark = {
  chartCorrect: '#2886de',
  chartWrong: '#e0682b',
  chartSeq1: '#0c3b5e',
  chartSeq2: '#115ea3',
  chartSeq3: '#2886de',
  chartSeq4: '#62abf5',
}

const lightTheme = { ...webLightTheme, ...chartLight }
const darkTheme = { ...webDarkTheme, ...chartDark }

/** Fluent téma podle systémového nastavení (světlé/tmavé). */
export function ThemeProvider({ children }: { children: ReactNode }) {
  const [dark, setDark] = useState(() => window.matchMedia(query).matches)

  useEffect(() => {
    const mq = window.matchMedia(query)
    const onChange = (e: MediaQueryListEvent) => setDark(e.matches)
    mq.addEventListener('change', onChange)
    return () => mq.removeEventListener('change', onChange)
  }, [])

  return (
    <FluentProvider theme={dark ? darkTheme : lightTheme} style={{ minHeight: '100vh' }}>
      {children}
    </FluentProvider>
  )
}

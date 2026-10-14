import { useEffect, useState, type ReactNode } from 'react'
import { FluentProvider, webDarkTheme, webLightTheme } from '@fluentui/react-components'

const query = '(prefers-color-scheme: dark)'

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
    <FluentProvider theme={dark ? webDarkTheme : webLightTheme} style={{ minHeight: '100vh' }}>
      {children}
    </FluentProvider>
  )
}

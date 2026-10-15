import { useEffect, useState, useSyncExternalStore } from 'react'
import { Button, MessageBar, MessageBarBody } from '@fluentui/react-components'
import { ArrowDownloadRegular } from '@fluentui/react-icons'
import { getInstallPrompt, promptInstall, subscribeInstallPrompt } from './pwaInstall.ts'

/** „Přidat na plochu" — zobrazí se, jen když to prohlížeč nabízí (Chrome/Edge/Android; iOS přes Sdílet). */
export function InstallButton() {
  const prompt = useSyncExternalStore(subscribeInstallPrompt, getInstallPrompt)
  if (!prompt) return null
  return (
    <Button appearance="subtle" icon={<ArrowDownloadRegular />} onClick={() => void promptInstall()}>
      Přidat na plochu
    </Button>
  )
}

/** Upozornění při výpadku připojení — data (odpovědi, pokrok) se ukládají jen na server. */
export function OfflineNotice() {
  const [online, setOnline] = useState(() => navigator.onLine)
  useEffect(() => {
    const on = () => setOnline(true)
    const off = () => setOnline(false)
    window.addEventListener('online', on)
    window.addEventListener('offline', off)
    return () => {
      window.removeEventListener('online', on)
      window.removeEventListener('offline', off)
    }
  }, [])
  if (online) return null
  return (
    <MessageBar intent="warning">
      <MessageBarBody>Jsi offline — odpovědi se neuloží, dokud se připojení neobnoví.</MessageBarBody>
    </MessageBar>
  )
}

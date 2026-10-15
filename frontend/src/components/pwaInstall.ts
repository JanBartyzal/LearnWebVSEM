// Instalace PWA a registrace service workeru (bez komponent — kvůli Fast Refresh v samostatném souboru).

interface InstallPromptEvent extends Event {
  prompt: () => Promise<void>
  userChoice: Promise<{ outcome: 'accepted' | 'dismissed' }>
}

// Prohlížeč pošle `beforeinstallprompt` jen jednou a brzy — zachytíme ho už při načtení modulu.
let deferred: InstallPromptEvent | null = null
const listeners = new Set<() => void>()
const notify = () => listeners.forEach((l) => l())

if (typeof window !== 'undefined') {
  window.addEventListener('beforeinstallprompt', (e) => {
    e.preventDefault()
    deferred = e as InstallPromptEvent
    notify()
  })
  window.addEventListener('appinstalled', () => {
    deferred = null
    notify()
  })
}

/** Registrace service workeru (jen produkční build — v dev serveru by cachoval moduly Vite). */
export function registerServiceWorker() {
  if (!import.meta.env.PROD || !('serviceWorker' in navigator)) return
  window.addEventListener('load', () => {
    navigator.serviceWorker.register('/sw.js').catch(() => {
      /* bez service workeru aplikace funguje dál, jen ji nejde nainstalovat */
    })
  })
}

export const subscribeInstallPrompt = (l: () => void) => {
  listeners.add(l)
  return () => listeners.delete(l)
}

export const getInstallPrompt = () => deferred

/** Nabídne instalaci; po volbě uživatele se tlačítko skryje. */
export async function promptInstall() {
  if (!deferred) return
  await deferred.prompt()
  await deferred.userChoice
  deferred = null
  notify()
}

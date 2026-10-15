import { useEffect } from 'react'

/** Název záložky / okna nainstalované aplikace: „Opakování · LearnWeb". */
export function useDocumentTitle(title?: string) {
  useEffect(() => {
    document.title = title ? `${title} · LearnWeb` : 'LearnWeb'
  }, [title])
}

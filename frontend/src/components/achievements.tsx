import { useCallback } from 'react'
import { useQueryClient } from '@tanstack/react-query'
import { Toast, ToastBody, ToastTitle, useToastController } from '@fluentui/react-components'
import { TrophyFilled } from '@fluentui/react-icons'
import { api } from '../api/client.ts'
import type { Badge } from '../api/types.ts'

/** Id společného Toasteru (umístěn v Layoutu). */
export const APP_TOASTER = 'app'

/** Oznámí nově získané odznaky (bez penalizací — jen pochvala). */
export function useNotifyBadges() {
  const { dispatchToast } = useToastController(APP_TOASTER)
  return useCallback(
    (badges: Badge[]) =>
      badges.forEach((b) =>
        dispatchToast(
          <Toast>
            <ToastTitle media={<TrophyFilled />}>Nový odznak: {b.name}</ToastTitle>
            <ToastBody>{b.description}</ToastBody>
          </Toast>,
          { intent: 'success', timeout: 6000 },
        ),
      ),
    [dispatchToast],
  )
}

type SessionBody = Parameters<typeof api.completeSession>[0]

/**
 * Zaznamená dokončenou seanci (počítá se do série dní) a oznámí nové odznaky.
 * Chyba záznamu se studentovi nehlásí — učení samotné tím nijak neutrpí.
 */
export function useCompleteSession() {
  const qc = useQueryClient()
  const notify = useNotifyBadges()
  return useCallback(
    async (body: SessionBody) => {
      try {
        const outcome = await api.completeSession(body)
        notify(outcome.newBadges)
      } catch {
        /* záznam seance je jen pro statistiky */
      }
      qc.invalidateQueries({ queryKey: ['stats'] })
      qc.invalidateQueries({ queryKey: ['stats-overview'] })
      qc.invalidateQueries({ queryKey: ['subject-stats'] })
    },
    [notify, qc],
  )
}

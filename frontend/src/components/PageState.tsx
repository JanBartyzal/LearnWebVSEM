import { MessageBar, MessageBarBody, MessageBarTitle, Spinner } from '@fluentui/react-components'

/** Jednotné zobrazení načítání a chyby pro React Query dotazy. */
export function PageState({ isLoading, error }: { isLoading: boolean; error: unknown }) {
  if (isLoading) return <Spinner label="Načítám…" />
  if (error)
    return (
      <MessageBar intent="error">
        <MessageBarBody>
          <MessageBarTitle>Nepodařilo se načíst data</MessageBarTitle>
          {error instanceof Error ? error.message : String(error)}
        </MessageBarBody>
      </MessageBar>
    )
  return null
}

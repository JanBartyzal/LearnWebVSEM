/**
 * Má globální klávesová zkratka událost ignorovat? Psaní do polí ano; Enter/mezerník na tlačítku také —
 * tlačítko na ně samo vyvolá klik, takže by se akce provedla dvakrát.
 */
export function ignoreShortcut(e: KeyboardEvent): boolean {
  const t = e.target
  if (t instanceof HTMLInputElement || t instanceof HTMLTextAreaElement || t instanceof HTMLSelectElement) return true
  return (e.key === 'Enter' || e.key === ' ') && t instanceof HTMLButtonElement
}

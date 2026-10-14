import { Field, ProgressBar } from '@fluentui/react-components'

/** Zvládnutí 0–1 jako ukazatel s procenty (informace nikdy jen barvou). */
export function MasteryBar({ value, label = 'Zvládnuto' }: { value: number; label?: string }) {
  const pct = Math.round(value * 100)
  return (
    <Field label={`${label}: ${pct} %`} size="small">
      <ProgressBar value={value} thickness="large" color={pct >= 85 ? 'success' : 'brand'} />
    </Field>
  )
}

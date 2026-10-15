import { makeStyles } from '@fluentui/react-components'

/** Drobečková navigace se dlouhými názvy témat zalomí místo přetečení do šířky (mobil na výšku). */
export const useCrumbStyles = makeStyles({
  wrap: {
    '& ol': { flexWrap: 'wrap' },
    '& .fui-BreadcrumbButton': { whiteSpace: 'normal', height: 'auto', textAlign: 'left' },
  },
})

import { makeStyles, tokens } from '@fluentui/react-components'

/** Kdo má v systému omezené animace, nedostane žádné (přístupnost). */
const reduce = '@media (prefers-reduced-motion: reduce)'

/**
 * Krátké, nenápadné animace (BA §5 fáze 5 „UX ladění — animace"): jen potvrzují akci, nic nezdržují.
 * Použití: `className={mergeClasses(…, motion.reveal)}` a `key`, aby se animace přehrála znovu.
 */
export const useMotion = makeStyles({
  reveal: {
    animationName: { from: { opacity: 0, transform: 'translateY(8px)' }, to: { opacity: 1, transform: 'none' } },
    animationDuration: tokens.durationNormal,
    animationTimingFunction: tokens.curveDecelerateMid,
    [reduce]: { animationName: 'none' },
  },
  pop: {
    animationName: { '0%': { transform: 'scale(1)' }, '40%': { transform: 'scale(1.03)' }, '100%': { transform: 'scale(1)' } },
    animationDuration: tokens.durationSlow,
    animationTimingFunction: tokens.curveEasyEase,
    [reduce]: { animationName: 'none' },
  },
  shake: {
    animationName: {
      '0%': { transform: 'translateX(0)' },
      '25%': { transform: 'translateX(-4px)' },
      '75%': { transform: 'translateX(4px)' },
      '100%': { transform: 'translateX(0)' },
    },
    animationDuration: tokens.durationNormal,
    animationIterationCount: 2,
    [reduce]: { animationName: 'none' },
  },
})

/**
 * Hlavní akce seance (Další / Rozumím) — na mobilu lepí ke spodnímu okraji, aby byla na dosah palce,
 * i když je otázka nebo karta dlouhá. Respektuje výřez displeje (safe area).
 */
export const useStickyActions = makeStyles({
  bar: {
    '@media (max-width: 600px)': {
      position: 'sticky',
      bottom: 0,
      zIndex: 5,
      marginInline: `calc(-1 * ${tokens.spacingHorizontalL})`,
      paddingInline: tokens.spacingHorizontalL,
      paddingTop: tokens.spacingVerticalS,
      paddingBottom: `max(${tokens.spacingVerticalS}, env(safe-area-inset-bottom))`,
      backgroundColor: tokens.colorNeutralBackground1,
      borderTop: `1px solid ${tokens.colorNeutralStroke2}`,
    },
  },
})

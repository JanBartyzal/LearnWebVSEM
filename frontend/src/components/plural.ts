/** České skloňování podle počtu: 1 karta, 2–4 karty, 0 a 5+ karet. */
export function plural(n: number, one: string, few: string, many: string) {
  return n === 1 ? one : n >= 2 && n <= 4 ? few : many
}

export const cardsWord = (n: number) => plural(n, 'karta', 'karty', 'karet')

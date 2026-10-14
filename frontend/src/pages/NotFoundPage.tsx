import { Link } from 'react-router-dom'
import { Body1, Title2 } from '@fluentui/react-components'

export function NotFoundPage() {
  return (
    <>
      <Title2 as="h1">Stránka nenalezena</Title2>
      <Body1 as="p">
        <Link to="/">Zpět na přehled předmětů</Link>
      </Body1>
    </>
  )
}

import ReactMarkdown from 'react-markdown'
import remarkGfm from 'remark-gfm'
import { makeStyles, tokens } from '@fluentui/react-components'

const useStyles = makeStyles({
  root: {
    lineHeight: tokens.lineHeightBase400,
    fontSize: tokens.fontSizeBase400,
    '& p': { marginBlock: tokens.spacingVerticalS },
    '& table': { borderCollapse: 'collapse', width: '100%', fontSize: tokens.fontSizeBase300 },
    '& th, & td': {
      border: `1px solid ${tokens.colorNeutralStroke2}`,
      padding: `${tokens.spacingVerticalXS} ${tokens.spacingHorizontalS}`,
      textAlign: 'left',
      verticalAlign: 'top',
    },
    '& th': { backgroundColor: tokens.colorNeutralBackground3 },
  },
  tableWrap: { overflowX: 'auto' },
})

export function Markdown({ children }: { children: string }) {
  const s = useStyles()
  return (
    <div className={s.root}>
      <ReactMarkdown
        remarkPlugins={[remarkGfm]}
        components={{ table: (props) => <div className={s.tableWrap}><table {...props} /></div> }}
      >
        {children}
      </ReactMarkdown>
    </div>
  )
}

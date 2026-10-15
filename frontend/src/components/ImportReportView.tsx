import {
  makeStyles,
  MessageBar,
  MessageBarBody,
  MessageBarTitle,
  Table,
  TableBody,
  TableCell,
  TableHeader,
  TableHeaderCell,
  TableRow,
  tokens,
} from '@fluentui/react-components'
import type { ImportReport } from '../api/types.ts'

const useStyles = makeStyles({
  root: { display: 'flex', flexDirection: 'column', gap: tokens.spacingVerticalS, marginTop: tokens.spacingVerticalM },
  tableWrap: { overflowX: 'auto', maxHeight: '320px', overflowY: 'auto' },
})

export function ImportReportView({ report }: { report: ImportReport }) {
  const s = useStyles()
  const errors = report.issues.filter((i) => i.isError)
  const c = report.counts
  const summary =
    `Oblasti: +${c.areasCreated} nových, ${c.areasUpdated} změněných · ` +
    `Předměty: +${c.subjectsCreated} nových, ${c.subjectsUpdated} změněných · ` +
    `Témata: +${c.topicsCreated}, ${c.topicsUpdated} změněných · ` +
    `Karty: +${c.cardsCreated}, ${c.cardsUpdated} změněných, ${c.cardsArchived} archivovaných · ` +
    `Otázky: +${c.questionsCreated}, ${c.questionsUpdated} změněných, ${c.questionsArchived} archivovaných`

  return (
    <div className={s.root}>
      {errors.length > 0 ? (
        <MessageBar intent="error">
          <MessageBarBody>
            <MessageBarTitle>Import neproběhl</MessageBarTitle>
            {errors.length} chyb v {report.fileCount} souborech — nic nebylo uloženo.
          </MessageBarBody>
        </MessageBar>
      ) : (
        <MessageBar intent={report.applied ? 'success' : 'info'}>
          <MessageBarBody>
            <MessageBarTitle>{report.applied ? 'Importováno' : 'Kontrola v pořádku (nic neuloženo)'}</MessageBarTitle>
            {report.fileCount} souborů. {summary}
          </MessageBarBody>
        </MessageBar>
      )}

      {report.issues.length > 0 && (
        <div className={s.tableWrap}>
          <Table size="small" aria-label="Nalezené problémy">
            <TableHeader>
              <TableRow>
                <TableHeaderCell>Typ</TableHeaderCell>
                <TableHeaderCell>Soubor:řádek</TableHeaderCell>
                <TableHeaderCell>Zpráva</TableHeaderCell>
              </TableRow>
            </TableHeader>
            <TableBody>
              {report.issues.map((i, n) => (
                <TableRow key={n}>
                  <TableCell>{i.isError ? 'Chyba' : 'Varování'}</TableCell>
                  <TableCell>
                    {i.file}:{i.line}
                  </TableCell>
                  <TableCell>{i.message}</TableCell>
                </TableRow>
              ))}
            </TableBody>
          </Table>
        </div>
      )}
    </div>
  )
}

import { useRef, useState } from 'react'
import { useMutation, useQuery, useQueryClient } from '@tanstack/react-query'
import {
  Badge,
  Body1,
  Button,
  Caption1,
  Card,
  CardHeader,
  Field,
  Input,
  makeStyles,
  MessageBar,
  MessageBarBody,
  Select,
  Spinner,
  Text,
  Textarea,
  Title2,
  tokens,
} from '@fluentui/react-components'
import {
  ArrowDownloadRegular,
  ArrowUploadRegular,
  CheckmarkCircleRegular,
  FolderOpenRegular,
  SparkleRegular,
} from '@fluentui/react-icons'
import { api } from '../api/client.ts'
import type { ImportReport } from '../api/types.ts'
import { ImportReportView } from '../components/ImportReportView.tsx'
import { useDocumentTitle } from '../components/useDocumentTitle.ts'

const useStyles = makeStyles({
  sections: { display: 'flex', flexDirection: 'column', gap: tokens.spacingVerticalL, marginTop: tokens.spacingVerticalL },
  row: { display: 'flex', flexWrap: 'wrap', gap: tokens.spacingHorizontalS, alignItems: 'center' },
  form: { display: 'grid', gap: tokens.spacingVerticalM, gridTemplateColumns: 'repeat(auto-fit, minmax(220px, 1fr))' },
  muted: { color: tokens.colorNeutralForeground3 },
  editor: { fontFamily: tokens.fontFamilyMonospace, minHeight: '320px' },
  hidden: { display: 'none' },
})

export function ContentPage() {
  useDocumentTitle('Správa obsahu')
  const s = useStyles()
  return (
    <>
      <Title2 as="h1">Správa obsahu</Title2>
      <Body1 as="p" className={s.muted}>
        Obsah žije v databázi. MD soubory slouží jako záloha a pro přidání či úpravu obsahu — formát popisuje{' '}
        <code>content/README.md</code>.
      </Body1>
      <div className={s.sections}>
        <UploadSection />
        <DirectoryAndExportSection />
        <DraftSection />
        <HistorySection />
      </div>
    </>
  )
}

function useImport<T>(fn: (arg: T) => Promise<ImportReport>) {
  const qc = useQueryClient()
  return useMutation({
    mutationFn: fn,
    onSuccess: (r) => {
      if (r.applied) qc.invalidateQueries()
    },
  })
}

function ErrorBar({ error }: { error: unknown }) {
  if (!error) return null
  return (
    <MessageBar intent="error">
      <MessageBarBody>{error instanceof Error ? error.message : String(error)}</MessageBarBody>
    </MessageBar>
  )
}

function UploadSection() {
  const s = useStyles()
  const [files, setFiles] = useState<File[]>([])
  const fileInput = useRef<HTMLInputElement>(null)
  const dirInput = useRef<HTMLInputElement>(null)
  const mutation = useImport((dryRun: boolean) => api.importFiles(files, dryRun))

  const pick = (list: FileList | null) => {
    setFiles(Array.from(list ?? []).filter((f) => /\.(md|zip)$/i.test(f.name)))
    mutation.reset()
  }

  // Nestandardní atribut pro výběr celé složky (podporují ho všechny hlavní prohlížeče).
  const directoryProps = { webkitdirectory: '' } as Record<string, string>

  return (
    <Card>
      <CardHeader
        image={<ArrowUploadRegular fontSize={24} />}
        header={<Text weight="semibold">Nahrát MD soubory</Text>}
        description={<Caption1>Jednotlivé soubory, celá složka předmětu nebo ZIP z exportu.</Caption1>}
      />
      <input ref={fileInput} className={s.hidden} type="file" multiple accept=".md,.zip"
        onChange={(e) => pick(e.target.files)} />
      <input ref={dirInput} className={s.hidden} type="file" multiple {...directoryProps}
        onChange={(e) => pick(e.target.files)} />
      <div className={s.row}>
        <Button onClick={() => fileInput.current?.click()}>Vybrat soubory…</Button>
        <Button icon={<FolderOpenRegular />} onClick={() => dirInput.current?.click()}>
          Vybrat složku…
        </Button>
        <Caption1>{files.length > 0 ? `${files.length} souborů vybráno` : 'Nic nevybráno'}</Caption1>
      </div>
      <div className={s.row}>
        <Button icon={<CheckmarkCircleRegular />} disabled={!files.length || mutation.isPending}
          onClick={() => mutation.mutate(true)}>
          Jen ověřit
        </Button>
        <Button appearance="primary" disabled={!files.length || mutation.isPending} onClick={() => mutation.mutate(false)}>
          Importovat
        </Button>
        {mutation.isPending && <Spinner size="tiny" />}
      </div>
      <ErrorBar error={mutation.error} />
      {mutation.data && <ImportReportView report={mutation.data} />}
    </Card>
  )
}

function DirectoryAndExportSection() {
  const s = useStyles()
  const mutation = useImport((dryRun: boolean) => api.importDirectory(dryRun))

  return (
    <Card>
      <CardHeader
        image={<FolderOpenRegular fontSize={24} />}
        header={<Text weight="semibold">Záloha na serveru (složka content/)</Text>}
        description={
          <Caption1>Znovu načíst MD zálohu připojenou ke kontejneru, nebo stáhnout aktuální stav DB jako MD.</Caption1>
        }
      />
      <div className={s.row}>
        <Button icon={<CheckmarkCircleRegular />} disabled={mutation.isPending} onClick={() => mutation.mutate(true)}>
          Ověřit složku
        </Button>
        <Button disabled={mutation.isPending} onClick={() => mutation.mutate(false)}>
          Importovat složku
        </Button>
        <Button as="a" href={api.exportUrl()} appearance="primary" icon={<ArrowDownloadRegular />}>
          Exportovat vše (ZIP)
        </Button>
        {mutation.isPending && <Spinner size="tiny" />}
      </div>
      <ErrorBar error={mutation.error} />
      {mutation.data && <ImportReportView report={mutation.data} />}
    </Card>
  )
}

function DraftSection() {
  const s = useStyles()
  const status = useQuery({ queryKey: ['llm-status'], queryFn: api.llmStatus, staleTime: 60_000 })
  const subjects = useQuery({ queryKey: ['subjects'], queryFn: api.subjects })
  const [subjectSlug, setSubjectSlug] = useState('')
  const subject = useQuery({
    queryKey: ['subject', subjectSlug],
    queryFn: () => api.subject(subjectSlug),
    enabled: subjectSlug.length > 0,
  })
  const [topicSlug, setTopicSlug] = useState('')
  const [cardCount, setCardCount] = useState(15)
  const [notes, setNotes] = useState('')
  const [markdown, setMarkdown] = useState('')
  const [fileName, setFileName] = useState('')

  const save = useImport((dryRun: boolean) => api.importText(fileName, markdown, dryRun))
  const draft = useMutation({
    mutationFn: () => api.draftTopic(subjectSlug, topicSlug, cardCount, notes),
    onSuccess: (d) => {
      setMarkdown(d.markdown)
      setFileName(d.fileName)
      save.reset()
    },
  })

  const llmReady = status.data?.configured && status.data.reachable

  return (
    <Card>
      <CardHeader
        image={<SparkleRegular fontSize={24} />}
        header={<Text weight="semibold">Návrh tématu přes AI</Text>}
        description={
          <Caption1>
            LLM (přes LiteLLM bránu) navrhne karty a otázky. Návrh se neuloží sám — zkontroluj ho, uprav a importuj.
          </Caption1>
        }
        action={
          status.isLoading ? (
            <Spinner size="tiny" />
          ) : (
            <Badge color={llmReady ? 'success' : 'warning'}>{llmReady ? 'AI dostupná' : 'AI nedostupná'}</Badge>
          )
        }
      />
      <div className={s.form}>
        <Field label="Předmět">
          <Select
            value={subjectSlug}
            onChange={(_, d) => {
              setSubjectSlug(d.value)
              setTopicSlug('')
            }}
          >
            <option value="">— vyber —</option>
            {subjects.data?.map((x) => (
              <option key={x.slug} value={x.slug}>
                {x.name}
              </option>
            ))}
          </Select>
        </Field>
        <Field label="Téma">
          <Select value={topicSlug} disabled={!subject.data} onChange={(_, d) => setTopicSlug(d.value)}>
            <option value="">— vyber —</option>
            {subject.data?.topics.map((t) => (
              <option key={t.slug} value={t.slug}>
                {t.order}. {t.name} ({t.cardCount} karet)
              </option>
            ))}
          </Select>
        </Field>
        <Field label="Počet karet">
          <Input type="number" min={3} max={40} value={String(cardCount)}
            onChange={(_, d) => setCardCount(Number(d.value) || 15)} />
        </Field>
      </div>
      <Field label="Vlastní podklady (volitelné) — výpisky, skripta; mají přednost před obecnými znalostmi modelu">
        <Textarea value={notes} onChange={(_, d) => setNotes(d.value)} resize="vertical" />
      </Field>
      <div className={s.row}>
        <Button appearance="primary" icon={<SparkleRegular />} disabled={!topicSlug || !llmReady || draft.isPending}
          onClick={() => draft.mutate()}>
          Vygenerovat návrh
        </Button>
        {draft.isPending && <Spinner size="tiny" label="Generuji, může to trvat i minuty…" />}
      </div>
      <ErrorBar error={draft.error} />

      {markdown && (
        <>
          <Field label={`Návrh: ${fileName}`}>
            <Textarea className={s.editor} value={markdown} onChange={(_, d) => setMarkdown(d.value)} resize="vertical" />
          </Field>
          <div className={s.row}>
            <Button icon={<CheckmarkCircleRegular />} disabled={save.isPending} onClick={() => save.mutate(true)}>
              Ověřit
            </Button>
            <Button appearance="primary" disabled={save.isPending} onClick={() => save.mutate(false)}>
              Importovat do DB
            </Button>
          </div>
          <ErrorBar error={save.error} />
          {save.data && <ImportReportView report={save.data} />}
        </>
      )}
    </Card>
  )
}

function HistorySection() {
  const s = useStyles()
  const { data } = useQuery({ queryKey: ['imports'], queryFn: api.importHistory })
  if (!data?.length) return null
  return (
    <Card>
      <CardHeader header={<Text weight="semibold">Historie importů</Text>} />
      {data.slice(0, 10).map((i) => (
        <Caption1 key={i.id}>
          <span className={s.muted}>{new Date(i.importedAt).toLocaleString('cs-CZ')}</span> · {i.source} ·{' '}
          {i.fileCount} souborů · {i.summary}
        </Caption1>
      ))}
    </Card>
  )
}

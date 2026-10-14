import type {
  AnswerResult,
  ImportHistoryItem,
  LearnedResult,
  QuizQuestion,
  StatsSummary,
  StudyMode,
  ImportReport,
  LlmStatus,
  SubjectDetail,
  SubjectSummary,
  TopicDetail,
  TopicDraft,
} from './types.ts'

export class ApiError extends Error {
  readonly status: number
  constructor(status: number, message: string) {
    super(message)
    this.status = status
  }
}

async function request<T>(url: string, init?: RequestInit): Promise<T> {
  const res = await fetch(url, init)
  if (!res.ok) {
    let message = `Chyba serveru (${res.status})`
    try {
      const body = await res.json()
      message = body.detail ?? body.error ?? body.title ?? message
    } catch {
      /* odpověď není JSON */
    }
    throw new ApiError(res.status, message)
  }
  return res.json() as Promise<T>
}

const json = (body: unknown): RequestInit => ({
  method: 'POST',
  headers: { 'Content-Type': 'application/json' },
  body: JSON.stringify(body),
})

export const api = {
  subjects: () => request<SubjectSummary[]>('/api/subjects'),
  subject: (slug: string) => request<SubjectDetail>(`/api/subjects/${encodeURIComponent(slug)}`),
  topic: (id: number) => request<TopicDetail>(`/api/topics/${id}`),

  quiz: (params: { topicId?: number; subjectSlug?: string; cardIds?: number[]; mode: StudyMode; count: number }) =>
    request<QuizQuestion[]>('/api/quiz', json(params)),
  answer: (questionId: number, selectedIndex: number, mode: StudyMode) =>
    request<AnswerResult>('/api/answers', json({ questionId, selectedIndex, mode })),
  learned: (cardId: number) => request<LearnedResult>(`/api/cards/${cardId}/learned`, { method: 'POST' }),
  stats: () => request<StatsSummary>('/api/stats/summary'),

  importFiles: (files: File[], dryRun: boolean) => {
    const form = new FormData()
    files.forEach((f) => form.append('files', f, f.webkitRelativePath || f.name))
    return request<ImportReport>(`/api/content/import?dryRun=${dryRun}`, { method: 'POST', body: form })
  },
  importText: (fileName: string, markdown: string, dryRun: boolean) =>
    request<ImportReport>('/api/content/import-text', json({ fileName, markdown, dryRun })),
  importDirectory: (dryRun: boolean) =>
    request<ImportReport>(`/api/content/import-directory?dryRun=${dryRun}`, { method: 'POST' }),
  importHistory: () => request<ImportHistoryItem[]>('/api/content/imports'),
  exportUrl: (subject?: string) =>
    subject ? `/api/content/export?subject=${encodeURIComponent(subject)}` : '/api/content/export',

  llmStatus: () => request<LlmStatus>('/api/content/llm/status'),
  draftTopic: (subjectSlug: string, topicSlug: string, cardCount: number, notes: string) =>
    request<TopicDraft>('/api/content/llm/draft-topic', json({ subjectSlug, topicSlug, cardCount, notes })),
}

import type {
  AnswerResult,
  AreaSummary,
  ContinueInfo,
  ExamOutcome,
  ExamPaper,
  ReviewSummary,
  SessionOutcome,
  StatsOverview,
  SubjectStats,
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
  areas: () => request<AreaSummary[]>('/api/areas'),
  subjects: () => request<SubjectSummary[]>('/api/subjects'),
  subject: (slug: string) => request<SubjectDetail>(`/api/subjects/${encodeURIComponent(slug)}`),
  topic: (id: number) => request<TopicDetail>(`/api/topics/${id}`),

  quiz: (params: {
    topicId?: number
    subjectSlug?: string
    cardIds?: number[]
    mode: StudyMode
    count: number
    excludeQuestionIds?: number[]
  }) => request<QuizQuestion[]>('/api/quiz', json(params)),
  /** `repeat` = kolikrát se karta v seanci už vrátila z horké fronty (0 = první pokus). */
  answer: (questionId: number, selectedIndex: number, mode: StudyMode, repeat = 0) =>
    request<AnswerResult>('/api/answers', json({ questionId, selectedIndex, mode, repeat })),
  learned: (cardId: number) => request<LearnedResult>(`/api/cards/${cardId}/learned`, { method: 'POST' }),
  stats: () => request<StatsSummary>('/api/stats/summary'),

  reviewSummary: () => request<ReviewSummary>('/api/review/summary'),
  review: (params: { subjectSlug?: string; ignoreDailyLimit?: boolean }) =>
    request<QuizQuestion[]>('/api/review', json(params)),
  continueInfo: () => request<ContinueInfo | null>('/api/continue'),

  composeExam: (subjectSlug: string, count: number) => request<ExamPaper>('/api/exams', json({ subjectSlug, count })),
  submitExam: (subjectSlug: string, startedAt: string, answers: { questionId: number; selectedIndex: number | null }[]) =>
    request<ExamOutcome>('/api/exams/submit', json({ subjectSlug, startedAt, answers })),
  completeSession: (body: {
    mode: Exclude<StudyMode, 'Exam'>
    subjectSlug?: string
    topicId?: number
    answered?: number
    correct?: number
    learned?: number
  }) => request<SessionOutcome>('/api/sessions', json(body)),
  statsOverview: () => request<StatsOverview>('/api/stats/overview'),
  subjectStats: (slug: string) => request<SubjectStats>(`/api/stats/subjects/${encodeURIComponent(slug)}`),

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

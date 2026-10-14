// Tvary odpovídají DTO v backend/src/LearnWeb.Api/Endpoints/*.cs

export interface SubjectSummary {
  id: number
  slug: string
  name: string
  order: number
  topicCount: number
  cardCount: number
  /** 0–1 */
  mastery: number
}

export interface TopicSummary {
  id: number
  slug: string
  name: string
  description: string
  order: number
  cardCount: number
  /** Počet již probraných karet */
  seenCount: number
  mastery: number
}

export interface SubjectDetail {
  id: number
  slug: string
  name: string
  goal: string
  mastery: number
  topics: TopicSummary[]
}

export type CardType = 'term' | 'explain' | 'compare'

export interface Card {
  id: number
  key: string
  type: CardType
  front: string
  back: string
  order: number
  questionCount: number
  seen: boolean
}

export interface TopicDetail {
  id: number
  slug: string
  name: string
  description: string
  subjectSlug: string
  subjectName: string
  cards: Card[]
}

export interface ContentIssue {
  file: string
  line: number
  message: string
  isError: boolean
}

export interface ImportCounts {
  subjectsCreated: number
  subjectsUpdated: number
  topicsCreated: number
  topicsUpdated: number
  cardsCreated: number
  cardsUpdated: number
  cardsArchived: number
  questionsCreated: number
  questionsUpdated: number
  questionsArchived: number
}

export interface ImportReport {
  applied: boolean
  dryRun: boolean
  fileCount: number
  issues: ContentIssue[]
  counts: ImportCounts
}

export interface ImportHistoryItem {
  id: number
  importedAt: string
  source: string
  fileCount: number
  summary: string
}

export interface LlmStatus {
  configured: boolean
  reachable: boolean
}

export interface TopicDraft {
  fileName: string
  markdown: string
  issues: ContentIssue[]
  isValid: boolean
}

// --- Učení a kvízy (backend/src/LearnWeb.Api/Study/StudyService.cs) ---

export type StudyMode = 'Learn' | 'Quiz' | 'Review' | 'Exam'

export interface QuizOption {
  /** Původní pořadí možnosti — posílá se zpět v odpovědi */
  index: number
  text: string
}

export interface QuizQuestion {
  questionId: number
  cardId: number
  cardFront: string
  topicName: string
  text: string
  options: QuizOption[]
}

export interface AnswerResult {
  isCorrect: boolean
  correctIndex: number
  explanation: string
  xpGained: number
  totalXp: number
  /** Opakovaná chyba — zobrazit celou kartu znovu */
  reteach: boolean
  box: number
  card: { id: number; type: CardType; front: string; back: string }
}

export interface LearnedResult {
  xpGained: number
  totalXp: number
  topicCompleted: boolean
}

export interface StatsSummary {
  xp: number
  level: number
  levelStartXp: number
  nextLevelXp: number
}

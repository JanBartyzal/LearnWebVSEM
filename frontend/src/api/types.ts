// Tvary odpovídají DTO v backend/src/LearnWeb.Api/Endpoints/*.cs

/** Oblast — hlavní záložka (VŠEM, TOGAF, ArchiMate, PRINCE2…) */
export interface AreaSummary {
  id: number
  slug: string
  name: string
  description: string
  order: number
  subjectCount: number
}

export interface SubjectSummary {
  id: number
  slug: string
  name: string
  order: number
  topicCount: number
  cardCount: number
  /** 0–1 */
  mastery: number
  areaSlug: string
}

/** Formát zkoušky nanečisto podle certifikace */
export interface ExamFormat {
  questions: number
  minutes: number
  passPercent: number
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
  areaSlug: string
  areaName: string
  /** null = výchozí formát (20–30 otázek, hranice 85 %) */
  exam: ExamFormat | null
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
  areaSlug: string
  areaName: string
}

export interface ContentIssue {
  file: string
  line: number
  message: string
  isError: boolean
}

export interface ImportCounts {
  areasCreated: number
  areasUpdated: number
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
  /** Horká fronta: vrátit kartu ještě v této seanci na konec */
  requeue: boolean
}

// --- Denní opakování a pokračování (fáze 3) ---

export interface SubjectReview {
  subjectId: number
  slug: string
  name: string
  /** Splatné karty */
  due: number
  reviewedToday: number
  /** Kolik zbývá dnes v rámci denního limitu */
  available: number
}

export interface ReviewSummary {
  /** Součet `available` přes předměty */
  total: number
  dailyLimitPerSubject: number
  subjects: SubjectReview[]
}

// --- Zkouška, seance, statistiky (fáze 4) ---

export interface StreakInfo {
  current: number
  longest: number
  activeToday: boolean
}

export interface Badge {
  code: string
  name: string
  description: string
}

export interface BadgeStatus extends Badge {
  earned: boolean
}

export interface SessionOutcome {
  streak: StreakInfo
  newBadges: Badge[]
}

export interface ExamPaper {
  subjectSlug: string
  subjectName: string
  timeLimitMinutes: number
  passPercent: number
  /** Počet otázek, čas a hranice úspěchu podle skutečné certifikace */
  certificationFormat: boolean
  questions: QuizQuestion[]
}

export interface ExamItemResult {
  questionId: number
  cardId: number
  cardFront: string
  topicId: number
  topicName: string
  text: string
  /** V původním pořadí — index = pozice */
  options: string[]
  selectedIndex: number | null
  correctIndex: number
  isCorrect: boolean
  explanation: string
}

export interface ExamTopicResult {
  topicId: number
  topicName: string
  correct: number
  total: number
}

export interface ExamOutcome {
  examId: number
  correct: number
  total: number
  percent: number
  passPercent: number
  passed: boolean
  xpGained: number
  totalXp: number
  /** Nejslabší témata první */
  topics: ExamTopicResult[]
  items: ExamItemResult[]
  streak: StreakInfo
  newBadges: Badge[]
}

export interface ActivityDay {
  /** YYYY-MM-DD (místní datum) */
  date: string
  sessions: number
  answers: number
  learned: number
}

export interface StatsOverview {
  xp: number
  level: number
  levelStartXp: number
  nextLevelXp: number
  streak: StreakInfo
  calendar: ActivityDay[]
  badges: BadgeStatus[]
  cardsSeen: number
  cardsTotal: number
  answers: number
  correctAnswers: number
  exams: number
}

export interface TopicStat {
  topicId: number
  name: string
  order: number
  cardCount: number
  seenCount: number
  mastery: number
}

export interface DailySuccess {
  date: string
  answered: number
  correct: number
}

export interface MissedCard {
  cardId: number
  front: string
  topicId: number
  topicName: string
  wrong: number
  attempts: number
  box: number
}

export interface ExamSummary {
  id: number
  finishedAt: string
  score: number
  total: number
  percent: number
}

export interface SubjectStats {
  subjectId: number
  slug: string
  name: string
  mastery: number
  topics: TopicStat[]
  daily: DailySuccess[]
  mostMissed: MissedCard[]
  exams: ExamSummary[]
  examPassPercent: number
}

export interface ContinueInfo {
  kind: 'learn' | 'practice'
  topicId: number
  topicName: string
  subjectSlug: string
  subjectName: string
  seenCount: number
  cardCount: number
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
  streak: StreakInfo
}

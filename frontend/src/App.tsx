import { Route, Routes } from 'react-router-dom'
import { Layout } from './components/Layout.tsx'
import { HomePage } from './pages/HomePage.tsx'
import { SubjectPage } from './pages/SubjectPage.tsx'
import { TopicPage } from './pages/TopicPage.tsx'
import { LearnPage } from './pages/LearnPage.tsx'
import { QuizPage } from './pages/QuizPage.tsx'
import { ContentPage } from './pages/ContentPage.tsx'
import { NotFoundPage } from './pages/NotFoundPage.tsx'

export default function App() {
  return (
    <Routes>
      <Route element={<Layout />}>
        <Route index element={<HomePage />} />
        <Route path="predmet/:slug" element={<SubjectPage />} />
        <Route path="tema/:id" element={<TopicPage />} />
        <Route path="uceni/:id" element={<LearnPage />} />
        <Route path="procvicovani" element={<QuizPage />} />
        <Route path="obsah" element={<ContentPage />} />
        <Route path="*" element={<NotFoundPage />} />
      </Route>
    </Routes>
  )
}

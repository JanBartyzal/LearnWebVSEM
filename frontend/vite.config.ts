import react from '@vitejs/plugin-react'
import { defineConfig } from 'vite'

// V dev režimu se /api proxyuje na backend (dotnet run nebo kontejner na :8080).
export default defineConfig({
  plugins: [react()],
  // Fluent UI je velká knihovna; jediný bundle je pro osobní nástroj v pořádku
  build: { chunkSizeWarningLimit: 1200 },
  server: {
    proxy: {
      '/api': process.env.VITE_API_PROXY ?? 'http://localhost:8080',
    },
  },
})

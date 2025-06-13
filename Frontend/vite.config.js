import { defineConfig } from 'vite';
import react from '@vitejs/plugin-react';
import tailwindcss from '@tailwindcss/vite';

export default defineConfig({
  plugins: [react(), tailwindcss()],
  server: {
    port: 5173,
    proxy: {
      '/api': {
        target: 'https://localhost:7175',
        changeOrigin: true,
        secure: false, // Bypass SSL verification for self-signed certificates
        //rewrite: (path) => path.replace(/^\/api/, ''), // Remove /api prefix if needed
      },
    },
  },
});
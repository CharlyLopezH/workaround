import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
//import App from './App.jsx'
import FirstApp from './FirstApp.jsx'
import { PruebaAxiosAysinc } from './componentes/PruebaAxiosAsync.tsx'
//import './index.css'

createRoot(document.getElementById('root')).render(
  <StrictMode>
    <PruebaAxiosAysinc/>
  </StrictMode>
)

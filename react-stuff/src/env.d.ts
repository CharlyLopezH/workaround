interface ImportMetaEnv {
    VITE_API_URL: string;
    // Agrega otras variables de entorno aquí
}

interface ImportMeta {
    readonly env: ImportMetaEnv;
}
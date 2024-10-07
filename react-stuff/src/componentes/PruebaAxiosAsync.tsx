import React, { useEffect, useState } from "react";
import axios from "axios";
import {permisoDTO} from "../permisos/permisos.model"

//Async/await es una forma más moderna de manejar los promesas.

export const PruebaAxiosAysinc = () => {

    
    const [datos, setDatos] = useState(([]));
    const [error, setError] = useState<string | null>(null);
    
    //Variables definidas en ./src/env.d.ts
    const apiUrl = import.meta.env.VITE_API_URL;
    console.log('API URL:', apiUrl); // Para verificar el valor
    
    useEffect(() => {
        const obtenerRegistros = async () => {
            try {
                const respuesta = (await axios.get( `${apiUrl}/permisos`)).data;
                setDatos(respuesta);
                console.log(respuesta);
            } catch (err: any) {
                setError(err.message);
                console.log('Error desde el UI -->',err.message)
            } finally {
                console.log('Finally...');
            }
        };
        obtenerRegistros();
    }, []);

    return(
        <>
        <h2>Axios Sample</h2>
        <code>Voy a conectarme con una URL por medio de Axios</code>
        <h5>Dentro del Return del componente</h5>    
        <code>//Desarrollar código para visualizar los datos en la UI</code>     
        </>
    )
}

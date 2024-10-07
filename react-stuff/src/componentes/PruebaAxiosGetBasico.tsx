//Ejemplo básico para acceder a un Endpoint, y recuperar la información del GET

import axios, { AxiosResponse } from "axios";
import React, { useEffect, useState } from "react";
import {permisoDTO} from "../permisos/permisos.model"



export const PruebaAxios = () => {

    const [datos, setDatos] = useState(([]));

    useEffect(()=>{    
                
        console.log('Entrando al use efect-->');       
        axios.get('https://localhost:7093/permisos')
        .then((respuesta:AxiosResponse<permisoDTO[]>)=> {
        console.log(respuesta.data);        
        })
        
        
    },[])
    
    return(
        <>
        <h2>Axios Sample</h2>
        <code>Voy a conectarme con una URL por medio de Axios</code>
        <h5>Dentro del Return del componente</h5>    
        <code>Desarrollar código para visualizar los datos en la UI</code>     
        </>
    )
}

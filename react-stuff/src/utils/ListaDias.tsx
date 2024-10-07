import React, { useEffect } from "react"


export const ListaDias=()=> {
//Parte programática
    const printMensaje =(txt: string)=>{
        console.log('Hola '+txt);
    }
    useEffect(()=>{printMensaje('Aquí vamos en el useEffect...')},[])
    
//Programación UI    
    return (
        <>
        <h5>
            Llamando al URL del API que regresa los días de un Empleado
        </h5>
        </>
    )
}
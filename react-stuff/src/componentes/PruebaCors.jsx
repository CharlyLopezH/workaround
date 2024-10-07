const urlWebAPI = 'https://localhost:7093/permisos';
console.log('Aquí voy, url del servidor',urlWebAPI);

consumirWebAPI(); 
async function consumirWebAPI() {
    const respuesta = await fetch(urlWebAPI, {
        method: 'GET',
        headers: {
            'Content-Type': 'application/json'
        }
    });

    const json = await respuesta.text();
    console.log(json);
}


export const PruebaCors=() => {
    
    return(
        <>
        <h2>
            Prueba de Cors
        </h2>        
        </>
    )
}
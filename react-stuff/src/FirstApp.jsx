//Parte programática
const sumaDatos=(a,b) => {
    return a+b;
}
export const FirstApp=()=> {    
//Programación de la parte visual
    return(
        <>
        <h1>Primera App Demo</h1>
        <h2>Suma:</h2>

        <h2>{sumaDatos(3,9)}</h2>        
        </>
    )
}
export default FirstApp;
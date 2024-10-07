import React from "react";
import { permiso } from "./permisos.model";

export default function PermisoIndividual(props:permisoIndividualProps) {

    return(
        <>
        <div>
            <a>{props.permiso.id}</a>
            <a>{props.permiso.fecha}</a>

        </div>
        </>
    )

}


interface permisoIndividualProps {
    permiso:permiso;
}
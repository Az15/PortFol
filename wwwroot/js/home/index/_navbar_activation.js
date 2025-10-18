// wwwroot/js/Home/Index/_navbar_activation.js

// Importamos la función de la carpeta compartida (sube dos niveles: Index -> Home -> js -> shared)
// RUTA CORREGIDA:
import { expandNavbar } from '/js/shared/_navbar_collapser.js';

/**
 * Exporta la función que activa el estado final de la Navbar
 * (llamada por resolveBugAndAdvance).
 */
export const activateFinalNavbarState = () => {
    expandNavbar();

    console.log("Navbar final state activated.");
};
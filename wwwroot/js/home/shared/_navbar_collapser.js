// wwwroot/js/shared/_navbar_collapser.js (Contiene la lógica de interacción
export const initializeNavbar = () => {
    const navbar = document.getElementById('main-navbar');
    // Lógica para el botón de expansión de la cápsula (flecha)
    // Agregamos listeners para el menú responsivo si es necesario

    console.log("Navbar listeners inicializados.");
};

// Esta función es llamada por _intro_terminal_sequence.js
export const expandNavbar = () => {
    const navbar = document.getElementById('main-navbar');
    if (navbar) {
        // Esta es la clase que aplicará el CSS con la animación de expansión
        navbar.classList.add('expanded');
    }
}
// entry.js

import { startIntroSequence, setMessages } from './_intro_terminal_sequence.js';
import { attachBugHandler } from './_bug_popup_handler.js';
// Importamos las funciones necesarias del shared module:
import { initializeNavbar } from '/js/shared/_navbar_collapser.js';


document.addEventListener('DOMContentLoaded', () => {
    // 1. Configuración de Mensajes (del Razor)
    if (typeof INTRO_MESSAGES !== 'undefined') {
        setMessages(INTRO_MESSAGES);
    }

    // 2. Inicialización de Componentes

    // Inicializar listeners del menú (debe hacerse siempre al cargar)
    initializeNavbar(); // Se llama a la función de _navbar_collapser.js

    // Adjuntar el listener al botón del bug
    attachBugHandler();

    // 3. Inicia la animación de tecleado
    startIntroSequence();
});
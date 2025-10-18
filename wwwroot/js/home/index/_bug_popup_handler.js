import { resolveBugAndAdvance } from './_intro_terminal_sequence.js';

export const attachBugHandler = () => {
    const button = document.getElementById('fix-bug-button');
    if (button) {
        button.addEventListener('click', (e) => {
            e.preventDefault();
            // Llama a la función principal para resolver el bug.
            resolveBugAndAdvance();
        });
    }
};
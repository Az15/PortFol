// wwwroot/js/Home/Index/_intro_terminal_sequence.js

import { activateFinalNavbarState } from './_navbar_activation.js';

let messages = [];
let autoAdvanceTimer;
const BUG_POPUP_ID = 'bug-popup-container';

export const setMessages = (msgList) => {
    messages = msgList;
};

const showBugPopup = () => {
    const popup = document.getElementById(BUG_POPUP_ID);
    if (popup) {
        popup.classList.remove('hidden');
    }
};

export const resolveBugAndAdvance = () => {
    clearTimeout(autoAdvanceTimer);
    document.getElementById('intro-terminal').classList.add('fade-out');
    document.getElementById('main-dashboard-content').classList.remove('hidden');
    activateFinalNavbarState();
};

// Nueva función para simular el tecleado.
const typeMessageSequence = () => {
    const outputElement = document.getElementById('typing-output');
    if (!outputElement) return;

    let messageIndex = 0;

    // Función recursiva para "teclear" una sola línea
    const typeLine = (line, callback) => {
        let charIndex = 0;
        const typingSpeed = 50;

        const typeChar = () => {
            if (charIndex < line.length) {
                outputElement.textContent += line.charAt(charIndex);
                charIndex++;
                setTimeout(typeChar, typingSpeed);
            } else {
                outputElement.textContent += '\n';
                setTimeout(callback, 500);
            }
        };
        typeChar();
    };

    // Función principal para procesar todas las líneas
    const processNextMessage = () => {
        if (messageIndex < messages.length) {
            typeLine(messages[messageIndex], () => {
                messageIndex++;
                processNextMessage();
            });
        } else {
            // Cuando todo el texto ha terminado de teclear:
            showBugPopup();

            // Establecer el Auto-Avance
            autoAdvanceTimer = setTimeout(resolveBugAndAdvance, 10000);
        }
    };

    processNextMessage();
};


export const startIntroSequence = () => {
    // ESTA ES LA ÚNICA FUNCIÓN QUE DEBE QUEDAR EXPORTADA
    typeMessageSequence();
};


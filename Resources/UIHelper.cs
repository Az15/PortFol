namespace PortFol.Resources
{
    // Clase estática para ensamblar datos de la UI.
    public static class UIHelper
    {
        // Método estático para obtener la secuencia de introducción.
        public static List<string> GetIntroSequenceMessages()
        {
            // Composicion de la secuencia de terminal:
            return new List<string>
            {
                PortFol.Resources.UIText.Intro_Line1_Connecting,
                PortFol.Resources.UIText.Intro_Line2_AuthGranted,
                PortFol.Resources.UIText.Intro_Line3_SearchFile,
                PortFol.Resources.UIText.Intro_Line4_Loading,
                PortFol.Resources.UIText.Intro_Line5_Executing
            };
                }
        // Aquí podríamos agregar otros ensamblajes estáticos, como los títulos de las secciones.

    }
}

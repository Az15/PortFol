namespace PortFol.Resources
{
    // Clase estática para ensamblar datos de la UI.
    public static class UIHelper
    {
        // Método estático para obtener la secuencia de introducción.
        public static List<string> GetIntroSequenceMessages()
        {
            // Lógica de composición que utiliza los strings estáticos del .resx.
            return new List<string>
            {
                //PortFol.Resourses.UIText.Intro_Line1_Connecting,
                //PortFol.Resources.UIText.Intro_Line2_AuthGranted,
                //PortFol.Resources.UIText.Intro_Line3_CatFile
            };
        }

        // Aquí podríamos agregar otros ensamblajes estáticos, como los títulos de las secciones.
    }
}

namespace PortFol.Models
{
    public class ProjectTechnology
    {
        // Claves Primarias Compuestas (Foreign Keys)
        public int ProjectId { get; set; }
        public int TechnologyId { get; set; }

        // Propiedades de Navegación
        public Project Project { get; set; }
        public Technology Technology { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace PortFol.Models
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }

        // Usamos una FK a Technology para el nombre de la habilidad
        public int TechnologyId { get; set; }

        [Range(0, 100)]
        public int DominanceLevel { get; set; } // Nivel de 0 a 100 para gráficos

        public bool IsSoftSkill { get; set; } = false; // Distingue entre Hard y Soft Skill

        // Propiedad de Navegación
        public Technology Technology { get; set; }

        // Propiedad opcional para la descripción de una Soft Skill
        public string? Narrative { get; set; }
    }
}

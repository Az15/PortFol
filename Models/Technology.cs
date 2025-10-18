using System.ComponentModel.DataAnnotations;

namespace PortFol.Models
{
    public class Technology
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string IconCssClass { get; set; } // Para usar con Font Awesome o similar

        [Required]
        public string Category { get; set; } // Backend, Frontend, Database, Cloud

        // Propiedad de Navegación Inversa (para la relación Muchos a Muchos)
        public ICollection<ProjectTechnology> ProjectTechnologies { get;  set; }

        // Propiedad de Navegación Inversa (para la relación con Skill)
        public ICollection<Skill> Skills { get; set; }
    }
}

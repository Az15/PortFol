using System.ComponentModel.DataAnnotations;


namespace PortFol.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(300)]
        public string ShortDescription { get; set; }

        [Required]
        public string LongDescription { get; set; }

        // Uso de DisplayFormat para manejar la presentación de fechas
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; } // Puede ser nulo si está en curso

        [Required, Url]
        public string ProjectUrl { get; set; }

        [Url]
        public string GitHubUrl { get; set; }

        [Required, Url]
        public string ImageUrl { get; set; } // Ruta donde se guardó la imagen

        public bool IsFeatured { get; set; } = false;

        // Propiedad de Navegación para la relación Muchos a Muchos
        public ICollection<ProjectTechnology> ProjectTechnologies { get; set; }
    }
}

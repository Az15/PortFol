using System.ComponentModel.DataAnnotations;

namespace PortFol.Models
{
    public class FODAItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Type { get; set; } // F (Fortaleza), O (Oportunidad), D (Debilidad), A (Amenaza)

        [Required]
        public string Description { get; set; }

        public int Order { get; set; } // Para ordenar la presentación
    }
}

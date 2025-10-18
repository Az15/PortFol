using System.ComponentModel.DataAnnotations;

namespace PortFol.Models
{
    public class FAQ
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Question { get; set; }

        [Required]
        public string Answer { get; set; }

        public int DisplayOrder { get; set; } // Orden de visualización en el Accordion/Toggle
    }
}

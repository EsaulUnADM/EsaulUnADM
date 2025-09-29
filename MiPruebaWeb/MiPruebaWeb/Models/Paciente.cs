using System;
using System.ComponentModel.DataAnnotations;

namespace MiPruebaWeb.Models
{
    public class Paciente
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = null!;

        [StringLength(100)]
        public string Apellido { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [Phone]
        [StringLength(20)]
        public string? Telefono { get; set; }

        [EmailAddress]
        public string? Email { get; set; }
    }
}

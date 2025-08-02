using System.ComponentModel.DataAnnotations;

namespace ManejoAdopciones.Models
{
    public class MascotaAdopcion
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "La longitud del campo {0} debe estar entre {2} y {1}")]
        [Display(Name = "Nombre de la mascota")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Especie")]
        public string Especie { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Raza")]
        public string Raza { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Range(0, 30, ErrorMessage = "La edad debe estar entre {1} y {2} años")]
        [Display(Name = "Edad (años)")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Display(Name = "Nombre del adoptante")]
        public string NombreAdoptante { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [EmailAddress(ErrorMessage = "El campo debe ser un email válido")]
        [Display(Name = "Email del adoptante")]
        public string EmailAdoptante { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [Phone(ErrorMessage = "El campo debe ser un teléfono válido")]
        [Display(Name = "Teléfono del adoptante")]
        public string TelefonoAdoptante { get; set; }
    }
}
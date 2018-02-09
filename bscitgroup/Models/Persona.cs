using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;


namespace bscitgroup.Models
{
    public class Persona
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DNI { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        public string Celular { get; set; }

        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }

        [Required]
        [Display(Name = "País")]
        public string Pais { get; set; }

        [Required]
        public string Ciudad { get; set; }

        [Required]
        [Display(Name = "Profesión")]
        public string Profesion { get; set; }

        [Required]
        [Display(Name = "Institución")]
        public string Institucion { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Direccion de correo inválida")]
        public string Correo { get; set; }

        public virtual ICollection<Categorias> Intereses { get; set; }

        [Display(Name = "Servicios registrados")]
        public virtual ICollection<PersonaServicioDetalle> PersonaServicioDetalles { get; set; }
    }
}
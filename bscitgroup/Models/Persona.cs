using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace bscitgroup.Models
{
    public class Persona
    {
        [Key]
        public int DNI { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Celular { get; set; }
        public string Telefono { get; set; }
        [Required]
        public string Pais { get; set; }
        [Required]
        public string Ciudad { get; set; }
        [Required]
        public string Profesion { get; set; }
        [Required]
        public string Institucion { get; set; }
        [Required]
        public string Correo { get; set; }

        public ICollection<Categorias> Intereses { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;


namespace bscitgroup.Models
{
    public class Servicio
    {
        public int ServicioID { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Tipo { get; set; }


        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }
        public string Objetivo { get; set; }
        public Categorias Categoria { get; set; }

        public ICollection<PersonaServicioDetalle> PersonaServicioDetalles { get; set; }

    }
}
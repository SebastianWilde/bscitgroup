using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace bscitgroup.Models
{
    public class ServicioDetalle
    {
        [ForeignKey("Serivicio")]
        public int ServicioDetalleId { get; set; }

        [Required]
        [Display(Name = "Fecha de inicio")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaInicio { get; set; }

        [Required]
        [Display(Name = "Fecha de fin")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime FechaFin { get; set; }

        [Required]
        [Display(Name = "Hora de inicio")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm:ss tt}", ApplyFormatInEditMode = true)]
        public DateTime HoraInico { get; set; }

        [Required]
        [Display(Name = "Hora de fin")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm:ss tt}", ApplyFormatInEditMode = true)]
        public DateTime HoraFin { get; set; }

        [Required]
        [Column(TypeName = "money")]
        [DataType(DataType.Currency)]
        public decimal Costo { get; set; }

        [Required]
        public string Modalidad { get; set; }

        public virtual Servicio Servicio { get; set; }

    }
}

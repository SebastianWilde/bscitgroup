using System;
using System.ComponentModel.DataAnnotations;

namespace bscitgroup.Models
{
    public class PersonaServicioDetalle
    {
        public int PersonaServicioDetalleID { get; set; }
        public int PersonaID { get; set; }
        public int ServicioDetalleID { get; set; }
   
        public DateTime Inscripcion { get; set; }
        
        public bool Participacion { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual ServicioDetalle ServicioDetalle { get; set; }
    }
}
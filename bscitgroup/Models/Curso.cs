using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bscitgroup.Models
{
    public class Curso
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Nombre { get; set; }

        public decimal Pago { get; set; }

        public byte[] ImagenCurso { get; set; }

        public string ImagenCurso2 { get; set; }
        [Required]
        public string Contenido { get; set; }

        public string Contenido2 { get; set; }

        public string EContenido1 { get; set; }

        public string EContenido2 { get; set; }

        public string Objetivo1 { get; set; }

        public string Objetivo2 { get; set; }

        public string Objetivo3 { get; set; }

        public string Objetivo4 { get; set; }

        public string Objetivo5 { get; set; }

        public string Publico { get; set; }

        public string Certificacion { get; set; }

        public virtual ICollection<Persona> Personas
        {
            get; set;
        } /*Personas Instructor*/

        public string Instructor
        {
            get; set;
        } /*Personas Instructor*/


        [Required]
        public DateTime Fechainicio { get; set; }

        public DateTime Fechafin { get; set; }

        public string Informe { get; set; }

        public string Informe2 { get; set; }

    }
}

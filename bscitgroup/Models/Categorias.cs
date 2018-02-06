using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace bscitgroup.Models
{
    public class Categorias
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Nombre { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bscitgroup.Models
{
    public class File
    {
      
        public int FileId { get; set; }
        public byte [] Contenido { get ; set ; }
        public string TipoContenido { get; set; } //nose :v
        public int CursoId { get; set; }
        public FileType FileType { get; set; }
        public virtual Curso Curso { get; set; }
    }
}


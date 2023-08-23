using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayLandProyect
{
    public class Requisitos
    {
        [Key]
        public int id { get; set; }

        public string? procesador { get; set; }
        public string? sistema { get; set; }
        public string? memoria { get; set; }
        public string? graficos { get; set; }
        public string? directx { get; set; }
        public string? almacenamiento { get; set; }
        public string? tipoRequisitos { get; set; }
        public string? estado { get; set; }
    }
}

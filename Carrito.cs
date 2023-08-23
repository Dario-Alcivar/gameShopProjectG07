using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayLandProyect
{
    public class Carrito
    {
        [Key]
        public int id { get; set; }
        public int idCliente { get; set; }
        public int idJuego { get; set; }
        public int cantidad { get; set; }
        public string? estado { get; set; }
        public string transaccion { get; set; }


    }
}

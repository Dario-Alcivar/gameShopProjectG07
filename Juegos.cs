using System.ComponentModel.DataAnnotations;

namespace PlayLandProyect
{
    public class Juegos
    {
        [Key]
        public int Id { get; set; }
        public Requisitos? requisito { get; set; }
        public string? src { get; set; }
        public string? nombre { get; set; }
        public string? descripcion { get; set; }
        public double? precio { get; set; }
        public string? fechaLazamiento { get; set; }
        public int descuento { get; set; }
        public string? lanzamientoEstado { get; set; }
        public string? estado { get; set; }
    }
}
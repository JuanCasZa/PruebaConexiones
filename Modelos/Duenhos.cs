//Para conectar con la BD
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaConexion.Modelos
{
    public class Duenhos
    {
        [Key]public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Edad { get; set; }
        public string? Identificacion { get; set; }
    }
}

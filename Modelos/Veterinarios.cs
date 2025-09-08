//Para BD
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaConexion.Modelos
{
    public class Veterinarios
    {
        [Key]public int Id { get; set; }
        public string? Nombre { get; set; }
        public int? AnhosExperiencia { get; set; }
        public string? Turno { get; set; }
    }    
}

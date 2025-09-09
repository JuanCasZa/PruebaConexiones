/*
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
*/

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaConexion.Modelos
{
    public class Veterinario
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;

        public int AnhosExperiencia { get; set; }

        public string Turno { get; set; } = string.Empty;

        // Relación uno-a-muchos: un veterinario puede atender varias mascotas
        public ICollection<Mascota>? Mascotas { get; set; }
    }
}


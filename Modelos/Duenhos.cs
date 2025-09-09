//Para conectar con la BD
/*
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaConexion.Modelos
{
    public class Duenhos
    {
        [Key]public int Id { get; set; }
        public string? Nombre { get; set; }
        public int? Edad { get; set; }
        public string? Identificacion { get; set; }
    }
}
*/

//Para conectar con la BD
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaConexion.Modelos
{
    public class Duenho
    {
        [Key]
        public int Id { get; set; }

        public string? Nombre { get; set; }
        public int Edad { get; set; }
        public string? Identificacion { get; set; }

        // Relación uno-a-muchos: un dueño puede tener varias mascotas
        public ICollection<Mascota>? Mascotas { get; set; }
    }
}


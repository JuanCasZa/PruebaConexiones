//Para conexion BD
/*
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


//Para espacios de otras clases
using PruebaConexion.Modelos;

public class Mascotas
{
    [Key]public int Id { get; set; }
    public string? Nombre { get; set; }
    public int? Edad { get; set; }
    public string? Raza { get; set; }
    public decimal Peso { get; set; }

    //Como referencias a los objetos
    public int Duenho { get; set; }
    public int Veterinario { get; set; }

    //Para traer los objetos
    [ForeignKey("Duenho")]public Duenhos? _Duenho { get; set; }
    [ForeignKey("Veterinario")]public Veterinarios? _Veterinario { get; set; }
}
*/

//Para BD
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PruebaConexion.Modelos
{
    public class Mascota
    {
        [Key] 
        public int Id { get; set; }

        public string Nombre { get; set; } = string.Empty;
        public int Edad { get; set; }
        public string Raza { get; set; } = string.Empty;
        public decimal Peso { get; set; }

        // Claves foráneas
        public int DuenhoId { get; set; }
        public int VeterinarioId { get; set; }

        // Propiedades de navegación
        [ForeignKey("DuenhoId")] 
        public Duenho? Duenho { get; set; }

        [ForeignKey("VeterinarioId")] 
        public Veterinario? Veterinario { get; set; }
    }
}

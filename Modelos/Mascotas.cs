//Para conexion BD
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


//Para espacios de otras clases
using PruebaConexion.Modelos;

public class Mascotas
{
    [Key]public int Id { get; set; }
    public string? Nombre { get; set; }
    public string Edad { get; set; }
    public string? Raza { get; set; }
    //public decimal Peso { get; set; }

    //Como referencias a los objetos
    public int Duenho { get; set; }
    public int Veterinario { get; set; }

    //Para traer los objetos
    [ForeignKey("Duenho")]public Duenhos? _Duenho { get; set; }
    [ForeignKey("Veterinario")]public Veterinarios? _Veterinario { get; set; }
}
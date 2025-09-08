public class Mascotas
{
    public string? Nombre { get; set; }
    public int? Edad { get; set; }
    public string Raza { get; set; }
    public decimal? Peso { get; set; }

    //Como referencias a los objetos
    public int Duenho { get; set; }
    public int Veterinario { get; set; }

    //Para traer los objetos
    public Duenhos _Duenho { get; set; }
    public Veterinarios _Veterinario { get; set; }
}
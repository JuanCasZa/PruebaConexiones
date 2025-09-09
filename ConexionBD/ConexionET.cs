/*
using System.Data.SqlClient;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace PruebaConexion.ConexioBD
{
    public class ConexionET
    {
        private string cadenaConexion = "server=DESKTOP-PGQLEH1\\SQLEXPRESS;database=Veterinarias;Integrated Security=True;TrustServerCertificate=true";

        public void CargarMascotas()
        {
            var conexion = new Conexion();
            conexion.CadenaConexion = cadenaConexion;

            var lista = conexion.Mascotas.ToList();
            foreach (var mascotas in lista)
            {
                Console.WriteLine(mascotas.Id + " " + mascotas.Nombre);
            }
        }
    }

    public class Conexion : DbContext
    {
        public string? CadenaConexion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(this.CadenaConexion!, p => { });
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<Mascotas>? Mascotas { get; set; }
    }
}
*/
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PruebaConexion.Modelos;

namespace PruebaConexion.ConexionBD
{
    public class ConexionET
    {
        private string cadenaConexion = 
            "server=DESKTOP-PGQLEH1\\SQLEXPRESS;database=Veterinarias;Integrated Security=True;TrustServerCertificate=true";

        public void CargarMascotas()
        {
            using var conexion = new Conexion { CadenaConexion = cadenaConexion };

            var lista = conexion.Mascotas!.ToList();
            foreach (var mascota in lista)
            {
                Console.WriteLine($"{mascota.Id} {mascota.Nombre}");
            }
        }
    }

    public class Conexion : DbContext
    {
        public string? CadenaConexion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured && !string.IsNullOrEmpty(CadenaConexion))
            {
                optionsBuilder.UseSqlServer(CadenaConexion);
            }

            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        public DbSet<Mascota>? Mascotas { get; set; }
    }
}


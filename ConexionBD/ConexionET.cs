using System.Data.SqlClient;
using System.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using PruebaConexion.Modelos;

namespace PruebaConexion.ConexioBD
{
    public class ConexionET
    {
        private string cadenaConexion = "server=localhost;database=Veterinaria;Integrated Security=True;TrustServerCertificate=true";

        public void CargarDuenhos()
        {
            var conexion = new Conexion();
            conexion.CadenaConexion = cadenaConexion;

            var lista = conexion.Duenhos!.ToList();
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

        //public DbSet<Mascotas>? Mascotas { get; set; }
        public DbSet<Duenhos>? Duenhos { get; set; }
    }
}

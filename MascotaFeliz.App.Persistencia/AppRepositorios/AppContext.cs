using Microsoft.EntityFrameworkCore;
using MascotaFeliz.App.Dominio;
namespace MascotaFeliz.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<Consulta> Consultas {get; set;}
        public DbSet<Mascota> Mascotas {get; set;}
        public DbSet<Persona> Personas {get; set;}        
        public DbSet<Veterinario> Veterinarios {get; set;}
        
             
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
     {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder
            .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = MascotaFeliz.Data");
        }

     }  
    }
	
	
}
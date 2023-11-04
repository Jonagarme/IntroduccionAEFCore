using IntroduccionAEFCore.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace IntroduccionAEFCore
{
    public class ApplicactionDBContext : DbContext
    {
        public ApplicactionDBContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //modelBuilder.Entity<Genero>().HasKey(g => g.Id);
            //modelBuilder.Entity<Genero>().Property(g => g.Nombre).HasMaxLength(150);

        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(150);
        }

        public DbSet<Genero> Generos => Set<Genero>();
        public DbSet<Actor> Actores => Set<Actor>();
        public DbSet<Pelicula> Peliculas => Set<Pelicula>();
        public DbSet<Comentarios> Comentarios => Set<Comentarios>();
    }
}

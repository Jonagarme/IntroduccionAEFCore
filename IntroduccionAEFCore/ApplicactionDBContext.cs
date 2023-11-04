using IntroduccionAEFCore.Entidades;
using Microsoft.EntityFrameworkCore;

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

            modelBuilder.Entity<Genero>().HasKey(g => g.Id);
            modelBuilder.Entity<Genero>().Property(g => g.Nombre).HasMaxLength(150);
        }

        public DbSet<Genero> Generos => Set<Genero>();
    }
}

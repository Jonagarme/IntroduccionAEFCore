using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace IntroduccionAEFCore.Entidades.Configuraciones
{
    public class ActorConfig : IEntityTypeConfiguration<Actor>
    {
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            //modelBuilder.Entity<Actor>().Property(a => a.Nombre).HasMaxLength(150);
            builder.Property(a => a.FechaNacimiento).HasColumnType("date");
            builder.Property(a => a.Forturna).HasPrecision(18, 2);
        }
    }
}

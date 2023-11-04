using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace IntroduccionAEFCore.Entidades.Configuraciones
{
    public class ComentarioConfig : IEntityTypeConfiguration<Comentarios>
    {
        public void Configure(EntityTypeBuilder<Comentarios> builder)
        {
            builder.Property(a => a.Contenido).HasMaxLength(500);
        }
    }
}

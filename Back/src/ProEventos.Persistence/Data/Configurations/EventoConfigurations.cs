using Microsoft.EntityFrameworkCore;
using ProEventos.Domain;

namespace ProEventos.Persistence.Data.Configurations;

public class EventoConfiguration : IEntityTypeConfiguration<Evento>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Evento> builder)
    {
        builder.ToTable("Eventos");
        
        builder.HasKey( e => e.Id);
        
        builder.Property( e => e.Id)
                .HasColumnName("evento_id")
                .IsRequired();
    }
}
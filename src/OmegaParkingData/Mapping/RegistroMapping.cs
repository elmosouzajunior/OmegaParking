using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OmegaParkingBusiness.Models;

namespace OmegaParkingData.Mapping
{
    public class RegistroMapping : IEntityTypeConfiguration<Registro>
    {
        public void Configure(EntityTypeBuilder<Registro> builder)
        {
            builder.HasKey(r => r.Id);

            builder.Property(e => e.RegistroEntrada)
                .IsRequired();

            // 1 : 1 => Registro : Veiculo
            builder.HasOne(r => r.Veiculo);                 
                 
            builder.HasOne(r => r.Estacionamento)
                .WithMany(e => e.Registros)
                .HasForeignKey(e => e.Id);

            builder.ToTable("Registros");
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OmegaParkingBusiness.Models;

namespace OmegaParkingData.Mapping
{
    public class VeiculoMapping : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder.HasKey(v => v.Id);
            builder.Property(v => v.Placa)
                .IsRequired()
                .HasColumnType("varchar(8)");

            builder.Property(v => v.Marca)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(v => v.Modelo)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(v => v.Cor)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(v => v.Observacao)
                .HasColumnType("varchar(1000)");               

            builder.ToTable("Veiculos");
        }
    }
}

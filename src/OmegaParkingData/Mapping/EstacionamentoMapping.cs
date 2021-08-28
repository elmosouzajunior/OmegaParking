using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OmegaParkingBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmegaParkingData.Mapping
{
    public class EstacionamentoMapping : IEntityTypeConfiguration<Estacionamento>
    {
        public void Configure(EntityTypeBuilder<Estacionamento> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(e => e.TotalVagasAutomoveis)
                .IsRequired();

            builder.Property(e => e.TotalVagasMotocicletas)
                .IsRequired();

            builder.HasMany(e => e.Registros)
                .WithOne(r => r.Estacionamento)
                .HasForeignKey(r => r.EstacionamentoId);

            builder.ToTable("Estacionamentos");
        }
    }
}

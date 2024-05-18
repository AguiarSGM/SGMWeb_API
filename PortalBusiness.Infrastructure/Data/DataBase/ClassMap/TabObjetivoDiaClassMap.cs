using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalBusiness.Domain.Entities;

namespace PortalBusiness.Infrastructure.Data.DataBase.ClassMap;

public class TabObjetivoDiaClassMap : IEntityTypeConfiguration<TabObjetivoDiaIn>
{
    public void Configure(EntityTypeBuilder<TabObjetivoDiaIn> builder)
    {
        builder.ToTable("TABOBJETIVODIA");

        builder.HasKey(p => new { p.Data, p.CodigoSupervisor, p.CodigoUnidade});

        builder.Property(p => p.Data).HasColumnName("DATA");
        builder.Property(p => p.ValorMeta).HasColumnName("VALORMETA");
        builder.Property(p => p.CodigoSupervisor).HasColumnName("CODIGOSUPERVISOR");
        builder.Property(p => p.CodigoUnidade).HasColumnName("CODIGOUNIDADE");
    }
}
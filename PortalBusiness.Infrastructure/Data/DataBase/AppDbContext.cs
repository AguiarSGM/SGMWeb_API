using Microsoft.EntityFrameworkCore;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Domain.Entities.SalesClass;
using PortalBusiness.Infrastructure.Data.DataBase.ClassMap;

namespace PortalBusiness.Infrastructure.Data.DataBase;

public class AppDbContext : DbContext
{
    public DbSet<TabPedido> TabPedidos { get; set; }
    public DbSet<TabPedidoItens> TabPedidoItens { get; set; }
    public DbSet<TabObjetivoDiaIn> TabObjetivoDia { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.ApplyConfiguration(new TabPedidoClassMap());
        modelBuilder.ApplyConfiguration(new TabPedidoItensClassMap());
        modelBuilder.ApplyConfiguration(new TabObjetivoDiaClassMap());

        modelBuilder.Entity<TabObjetivoDiaIn>()
            .HasKey(p => new { p.Data, p.CodigoSupervisor, p.CodigoUnidade });

        modelBuilder.Entity<TabPedido>()
            .HasKey(p => new { p.CodigoPedidoRca, p.CodigoRca, p.DataHoraAberturaPedido });

        modelBuilder.Entity<TabPedidoItens>()
            .HasKey(item => new { item.CodigoPedidoRca, item.CodigoRca, item.DataHoraAberturaPedido, item.Item });

        modelBuilder.Entity<TabPedidoItens>()
            .HasOne(item => item.Pedido)
            .WithMany(pedido => pedido.Itens)
            .HasForeignKey(item => new { item.CodigoPedidoRca, item.CodigoRca, item.DataHoraAberturaPedido });

        base.OnModelCreating(modelBuilder);
    }
}

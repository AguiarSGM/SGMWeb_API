using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalBusiness.Domain.Entities.SalesClass;

namespace PortalBusiness.Infrastructure.Data.DataBase.ClassMap;

public class TabPedidoItensClassMap : IEntityTypeConfiguration<TabPedidoItens>
{
    public void Configure(EntityTypeBuilder<TabPedidoItens> builder)
    {
        builder.ToTable("TABPEDIDOITENS");

        builder.HasKey(p => new { p.CodigoPedidoRca, p.CodigoRca, p.DataHoraAberturaPedido, p.Item, p.CodigoProduto });

        builder.Property(p => p.CodigoPedidoRca).HasColumnName("CODIGOPEDIDORCA");
        builder.Property(p => p.CodigoRca).HasColumnName("CODIGORCA");
        builder.Property(p => p.DataHoraAberturaPedido).HasColumnName("DATAHORAABERTURAPEDIDO");
        builder.Property(p => p.Item).HasColumnName("ITEM");
        builder.Property(p => p.CodigoProduto).HasColumnName("CODIGOPRODUTO");
        builder.Property(p => p.DescricaoProduto).HasColumnName("DESCRICAOPRODUTO");
        builder.Property(p => p.Quantidade).HasColumnName("QUANTIDADE");
        builder.Property(p => p.PrecoVendaOriginal).HasColumnName("PRECOVENDAORIGINAL");
        builder.Property(p => p.PrecoVenda).HasColumnName("PRECOVENDA");
        builder.Property(p => p.CodigoBarras).HasColumnName("CODIGOBARRAS");
        builder.Property(p => p.QuantidadeFaturada).HasColumnName("QUANTIDADEFATURADA");
        builder.Property(p => p.Bonificacao).HasColumnName("BONIFICACAO");
        builder.Property(p => p.CodigoCombo).HasColumnName("CODIGOCOMBO");
        builder.Property(p => p.Corte).HasColumnName("CORTE");
        builder.Property(p => p.PercentualDesconto).HasColumnName("PERCENTUALDESCONTO");
        builder.Property(p => p.PercentualDescontoBoleto).HasColumnName("PERCENTUALDESCONTOBOLETO");
        builder.Property(p => p.Sugestao).HasColumnName("SUGESTAO");
        builder.Property(p => p.CodigoPedido).HasColumnName("CODIGOPEDIDO");
        builder.Property(p => p.PrecoVendaDesconto).HasColumnName("PRECOVENDADESCONTO");
        builder.Property(p => p.ValorTotal).HasColumnName("VALORTOTAL");
        builder.Property(p => p.ValorTotalComImposto).HasColumnName("VALORTOTALCOMIMPOSTO");
        builder.Property(p => p.CodigoDesconto3306).HasColumnName("CODIGODESCONTO3306");
        builder.Property(p => p.DescricaoDesconto3306).HasColumnName("DESCRICAODESCONTO3306");
        builder.Property(p => p.CodigoProdutoPrincipal).HasColumnName("CODIGOPRODUTOPRINCIPAL");
        builder.Property(p => p.ObservacaoRetorno).HasColumnName("OBSERVACAORETORNO");
        builder.Property(p => p.CodigoUnidadeRetira).HasColumnName("CODIGOUNIDADERETIRA");
        builder.Property(p => p.TipoEntrega).HasColumnName("TIPOENTREGA");
        builder.Property(p => p.CodigoDesconto561).HasColumnName("CODIGODESCONTO561");
        builder.Property(p => p.DiferencaPreco).HasColumnName("DIFERENCAPRECO");
        builder.Property(p => p.SaldoVerba).HasColumnName("SALDOVERBA");
        builder.Property(p => p.BaseCredDebRcaDesconto561).HasColumnName("BASECREDDEBRCADESCONTO561");
        builder.Property(p => p.AplicaAutomaticoDesconto561).HasColumnName("APLICAAUTOMATICODESCONTO561");
        builder.Property(p => p.PercentualDesconto561).HasColumnName("PERCENTUALDESCONTO561");
        builder.Property(p => p.CodigoAuxiliarEmbalagem).HasColumnName("CODIGOAUXILIAREMBALAGEM");
        builder.Property(p => p.QuantidadeUnitariaEmbalagem).HasColumnName("QUANTIDADEUNITARIAEMBALAGEM");
        builder.Property(p => p.UtilizaVendaPorEmbalagem).HasColumnName("UTILIZAVENDAPOREMBALAGEM");
        builder.Property(p => p.TipoCargaProduto).HasColumnName("TIPOCARGAPRODUTO");
        builder.Property(p => p.ExibeComboEmbalagem).HasColumnName("EXIBECOMBOEMBALAGEM");
        builder.Property(p => p.ItemNegociado).HasColumnName("ITEMNEGOCIADO");
        builder.Property(p => p.UnidadeVenda).HasColumnName("UNIDADEVENDA");
        builder.Property(p => p.TipoEstoqueProduto).HasColumnName("TIPOESTOQUEPRODUTO");
        builder.Property(p => p.CodigoRegiao).HasColumnName("CODIGOREGIAO");
        builder.Property(p => p.PercentualAcrescimo).HasColumnName("PERCENTUALACRESCIMO");
        builder.Property(p => p.Comissao).HasColumnName("COMISSAO");
        builder.Property(p => p.Peso).HasColumnName("PESO");
        builder.Property(p => p.ValorST).HasColumnName("VALORST");
        builder.Property(p => p.PrecoComST).HasColumnName("PRECOCOMST");
        builder.Property(p => p.valortotalcomst).HasColumnName("VALORTOTALCOMST");
        builder.Property(p => p.NumeroCarregamento).HasColumnName("NUMEROCARREGAMENTO");
        builder.Property(p => p.PercentualBaseRed).HasColumnName("PERCENTUALBASERED");
        builder.Property(p => p.PercentualICM).HasColumnName("PERCENTUALICM");
        builder.Property(p => p.DataValidadeCampanhaShelf).HasColumnName("DATAVALIDADECAMPANHASHELF");
        builder.Property(p => p.PrecoCampanhaShelf).HasColumnName("PRECOCAMPANHASHELF");
        builder.Property(p => p.CodigoCampanhaShelf).HasColumnName("CODIGOCAMPANHASHELF");
        builder.Property(p => p.UnidadeFrios).HasColumnName("UNIDADEFRIOS");

        // Mapeamento para a tabela principal de pedidos
        builder.HasOne(p => p.Pedido)
            .WithMany(p => p.Itens)
            .HasForeignKey(p => new { p.CodigoPedidoRca, p.CodigoRca, p.DataHoraAberturaPedido })
            .HasPrincipalKey(p => new { p.CodigoPedidoRca, p.CodigoRca, p.DataHoraAberturaPedido });
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PortalBusiness.Domain.Entities.SalesClass;

namespace PortalBusiness.Infrastructure.Data.DataBase.ClassMap;

public class TabPedidoClassMap : IEntityTypeConfiguration<TabPedido>
{
    public void Configure(EntityTypeBuilder<TabPedido> builder)
    {
        builder.ToTable("TABPEDIDO");

        builder.HasKey(p => new { p.CodigoPedidoRca, p.CodigoRca, p.DataHoraAberturaPedido });

        builder.Property(p => p.CodigoPedidoRca).HasColumnName("CODIGOPEDIDORCA");
        builder.Property(p => p.CodigoPedido).HasColumnName("CODIGOPEDIDO");
        builder.Property(p => p.CodigoRca).HasColumnName("CODIGORCA");
        builder.Property(p => p.NomeRca).HasColumnName("NOMERCA");
        builder.Property(p => p.CodigoCliente).HasColumnName("CODIGOCLIENTE");
        builder.Property(p => p.FantasiaCliente).HasColumnName("FANTASIACLIENTE");
        builder.Property(p => p.RazaoSocialCliente).HasColumnName("RAZAOSOCIALCLIENTE");
        builder.Property(p => p.CnpjCpfCliente).HasColumnName("CNPJCPFCLIENTE");
        builder.Property(p => p.DataHoraAberturaPedido).HasColumnName("DATAHORAABERTURAPEDIDO");
        builder.Property(p => p.DataHoraFechamentoPedido).HasColumnName("DATAHORAFECHAMENTOPEDIDO");
        builder.Property(p => p.NumeroPedidoCliente).HasColumnName("NUMEROPEDIDOCLIENTE");
        builder.Property(p => p.DataEntregaPedido).HasColumnName("DATAENTREGAPEDIDO");
        builder.Property(p => p.CodigoUnidadePedido).HasColumnName("CODIGOUNIDADEPEDIDO");
        builder.Property(p => p.CodigoUnidadeNfPedido).HasColumnName("CODIGOUNIDADENFPEDIDO");
        builder.Property(p => p.CodigoUnidadeRetiradaPedido).HasColumnName("CODIGOUNIDADERETIRADAPEDIDO");
        builder.Property(p => p.CodigoCobrancaPedido).HasColumnName("CODIGOCOBRANCAPEDIDO");
        builder.Property(p => p.CodigoPlanoPagamentoPedido).HasColumnName("CODIGOPLANOPAGAMENTOPEDIDO");
        builder.Property(p => p.CondicaoVendaPedido).HasColumnName("CONDICAOVENDAPEDIDO");
        builder.Property(p => p.ObservacaoPedido).HasColumnName("OBSERVACAOPEDIDO");
        builder.Property(p => p.ObservacaoEntregaPedido).HasColumnName("OBSERVACAOENTREGAPEDIDO");
        builder.Property(p => p.FreteDespachoPedido).HasColumnName("FRETEDESPACHOPEDIDO");
        builder.Property(p => p.FreteRedespachoPedido).HasColumnName("FRETEREDESPACHOPEDIDO");
        builder.Property(p => p.CodigoFornecedorFretePedido).HasColumnName("CODIGOFORNECEDORFRETEPEDIDO");
        builder.Property(p => p.Prazo1Pedido).HasColumnName("PRAZO1PEDIDO");
        builder.Property(p => p.Prazo2Pedido).HasColumnName("PRAZO2PEDIDO");
        builder.Property(p => p.Prazo3Pedido).HasColumnName("PRAZO3PEDIDO");
        builder.Property(p => p.Prazo4Pedido).HasColumnName("PRAZO4PEDIDO");
        builder.Property(p => p.Prazo5Pedido).HasColumnName("PRAZO5PEDIDO");
        builder.Property(p => p.Prazo6Pedido).HasColumnName("PRAZO6PEDIDO");
        builder.Property(p => p.Prazo7Pedido).HasColumnName("PRAZO7PEDIDO");
        builder.Property(p => p.Prazo8Pedido).HasColumnName("PRAZO8PEDIDO");
        builder.Property(p => p.Prazo9Pedido).HasColumnName("PRAZO9PEDIDO");
        builder.Property(p => p.Prazo10Pedido).HasColumnName("PRAZO10PEDIDO");
        builder.Property(p => p.Prazo11Pedido).HasColumnName("PRAZO11PEDIDO");
        builder.Property(p => p.Prazo12Pedido).HasColumnName("PRAZO12PEDIDO");
        builder.Property(p => p.OrigemPedido).HasColumnName("ORIGEMPEDIDO");
        builder.Property(p => p.NumeroPedidoComprador).HasColumnName("NUMEROPEDIDOCOMPRADOR");
        builder.Property(p => p.PosicaoAtualPedido).HasColumnName("POSICAOATUALPEDIDO");
        builder.Property(p => p.SaldoAtualRca).HasColumnName("SALDOATUALRCA");
        builder.Property(p => p.TipoPrioridadeEntregaPedido).HasColumnName("TIPOPRIORIDADEENTREGAPEDIDO");
        builder.Property(p => p.PercentualDescontoAbatimentoPedido).HasColumnName("PERCDESCABATIMENTOPEDIDO");
        builder.Property(p => p.CustoBonificacaoPedido).HasColumnName("CUSTOBONIFICACAOPEDIDO");
        builder.Property(p => p.CodFornecedorBonificacaoPedido).HasColumnName("CODFORNECBONIFICACAOPEDIDO");
        builder.Property(p => p.CodigoBonificacaoPedido).HasColumnName("CODIGOBONIFICACAOPEDIDO");
        builder.Property(p => p.AgrupamentoPedido).HasColumnName("AGRUPAMENTOPEDIDO");
        builder.Property(p => p.CodigoEnderecoEntregaPedido).HasColumnName("CODIGOENDERECOENTREGAPEDIDO");
        builder.Property(p => p.OrcamentoPedido).HasColumnName("ORCAMENTOPEDIDO");
        builder.Property(p => p.ValorDescontoAbatimentoPedido).HasColumnName("VALORDESCONTOABATIMENTOPEDIDO");
        builder.Property(p => p.ValorEntradaPedido).HasColumnName("VALORENTRADAPEDIDO");
        builder.Property(p => p.StatusPedido).HasColumnName("STATUSPEDIDO");
        builder.Property(p => p.TotalItensPedido).HasColumnName("TOTALITENSPEDIDO");
        builder.Property(p => p.TotalPedido).HasColumnName("TOTALPEDIDO");
        builder.Property(p => p.ValorTotalComST).HasColumnName("TOTALPEDIDOCOMIMPOSTO");
        builder.Property(p => p.ObservacaoRetorno).HasColumnName("OBSERVACAORETORNO");
        builder.Property(p => p.SaldoVerba).HasColumnName("SALDOVERBA");
        builder.Property(p => p.QuebraPedidoFrete).HasColumnName("QUEBRAPEDIDOFRETE");
        builder.Property(p => p.PercentualFreteOutraFilial).HasColumnName("PERCENTUALFRETEOUTRAFILIAL");
        builder.Property(p => p.CodigoFilialPedidoFrete).HasColumnName("CODIGOFILIALPEDIDOFRETE");
        builder.Property(p => p.CodigoProdutoPedidoFrete).HasColumnName("CODIGOPRODUTOPEDIDOFRETE");
        builder.Property(p => p.PrecoProdutoPedidoFrete).HasColumnName("PRECOPRODUTOPEDIDOFRETE");
        builder.Property(p => p.CodigoPedidoRcaPedidoFrete).HasColumnName("CODIGOPEDIDORCAPEDIDOFRETE");
        builder.Property(p => p.CidadeCliente).HasColumnName("CIDADECLIENTE");
        builder.Property(p => p.TipoEmissao).HasColumnName("TIPOEMISSAO");
        builder.Property(p => p.QuebraPedidoPrevenda).HasColumnName("QUEBRAPEDIDOPREVENDA");
        builder.Property(p => p.CodigoPedidoRcaPedidoPrevenda).HasColumnName("CODIGOPEDIDORCAPEDIDOPREVENDA");
        builder.Property(p => p.CodigoFilialPedidoPrevenda).HasColumnName("CODIGOFILIALPEDIDOPREVENDA");
        builder.Property(p => p.RetornoMotivoBloqueio).HasColumnName("RETORNOMOTIVOBLOQUEIO");
        builder.Property(p => p.RetornoValorPedido).HasColumnName("RETORNOVALORPEDIDO");
        builder.Property(p => p.RetornoValorAtendido).HasColumnName("RETORNOVALORATENDIDO");
        builder.Property(p => p.NumeroPedidoVenda).HasColumnName("NUMEROPEDIDOVENDA");
        builder.Property(p => p.DataEmissaoMapa).HasColumnName("DATAEMISSAOMAPA");
        builder.Property(p => p.NumeroPedidoErpOriginal).HasColumnName("NUMEROPEDIDOERPORIGINAL");
        builder.Property(p => p.Comissao).HasColumnName("COMISSAO");
        builder.Property(p => p.Peso).HasColumnName("PESO");
        builder.Property(p => p.GerouBrinde).HasColumnName("GEROUBRINDE");
        builder.Property(p => p.CodigoMotorista).HasColumnName("CODIGOMOTORISTA");
        builder.Property(p => p.NomeMotorista).HasColumnName("NOMEMOTORISTA");
        builder.Property(p => p.CelularMotorista).HasColumnName("CELULARMOTORISTA");
        builder.Property(p => p.DataCadastro).HasColumnName("DATACADASTRO");
        builder.Property(p => p.StatusProcessamento).HasColumnName("STATUSPROCESSAMENTO");
        builder.Property(p => p.DataProcessamento).HasColumnName("DATAPROCESSAMENTO");
        builder.Property(p => p.MensagemProcessamento).HasColumnName("MENSAGEMPROCESSAMENTO");
        builder.Property(p => p.NomeArquivoRemessa).HasColumnName("NOMEARQUIVOREMESSA");
        builder.Property(p => p.IdUsuario).HasColumnName("IDUSUARIO");
        builder.Property(p => p.EnderecoCliente).HasColumnName("ENDERECOCLIENTE");
        builder.Property(p => p.QtItensGravado).HasColumnName("QTITENSGRAVADO");
        builder.Property(p => p.QtItensPedido).HasColumnName("QTITENSPEDIDO");
        builder.Property(p => p.RetornoNumeroPedidoErp).HasColumnName("RETORNONUMEROPEDIDOERP");
        builder.Property(p => p.ValorFretePedido).HasColumnName("VALORFRETEPEDIDO");

        // Mapeamento para a lista de itens
        builder.HasMany(p => p.Itens)
            .WithOne()
            .HasForeignKey(p => p.CodigoPedidoRca);
    }
}

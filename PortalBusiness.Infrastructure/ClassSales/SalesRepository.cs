using Dapper;
using Microsoft.EntityFrameworkCore;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Domain.Entities.SalesClass;
using PortalBusiness.Infrastructure.Data.DataBase;
using PortalBusiness.Infrastructure.Data.Queries;
using PortalBusiness.Infrastructure.Interfaces.ContractSales;
using System.Data;
using System.Text;
using System.Xml.Serialization;
using static Dapper.SqlMapper;

namespace PortalBusiness.Infrastructure.ClassSales;

public class SalesRepository : ISalesRepository
{
    private readonly IDbConnection _dbConnection;
    private readonly AppDbContext _context;
    public SalesRepository(IDbConnection dbConnection, AppDbContext context)
    {
        _dbConnection = dbConnection;
        _context = context;
    }

    public async Task<SalesOutFullOrder> GetSalesFullRepositoryAsync(string codpedidorca)
    {
        try
        {
            string sqlSales = SqlQueries.SalesFull.Replace("@CODIGOPEDIDORCA", codpedidorca.ToString());
            string sqlSalesItems = SqlQueries.SalesItensFull.Replace("@CODIGOPEDIDORCA", codpedidorca.ToString());

            var result = await _dbConnection.QueryFirstAsync<SalesOutFullOrder>(sqlSales);
            var resultItems = await _dbConnection.QueryAsync<SalesOutFullItens>(sqlSalesItems);

            result.Itens = resultItems?.ToList();

            return result;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    public async Task<IEnumerable<Sales>> GetSalesRepositoryAsync(string iduser)
    {
        try
        {
            string sql = SqlQueries.Sales.Replace("@IDUSUARIO", iduser.ToString());

            var result = await _dbConnection.QueryAsync<Sales>(sql);

            return result;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    public async Task<IEnumerable<SalesItem>> GetSalesItensRepositoryAsync(int iduser, string codrca)
    {
        try
        {
            string sql = SqlQueries.SalesItens.Replace("@IDUSUARIO", iduser.ToString())
                                              .Replace("@CODIGOPEDIDORCA", codrca.ToString());

            var result = await _dbConnection.QueryAsync<SalesItem>(sql);

            return result;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    public async Task<SalesOrder> InsertSalesAsync(SalesOrder salesOrder)
    {
        try
        {
            var codPedidoRCA = (await NumeroPedidoRCA(salesOrder.id_usuario.ToString()));
            string sqlInsert = SqlQueries.SalesInsert;

            string sqlValue = SqlQueries.SalesInsertValue
                            .Replace("@CODIGOPEDIDORCA", codPedidoRCA.ToString())
                            .Replace("@CODIGOPEDIDO", salesOrder.codigo_pedido.ToString())
                            .Replace("@CODIGORCA", salesOrder.codigo_rca.ToString())
                            .Replace("@NOMERCA", salesOrder.nome_rca)
                            .Replace("@CODIGOCLIENTE", salesOrder.codigo_cliente.ToString())
                            .Replace("@FANTASIACLIENTE", salesOrder.fantasia_cliente)
                            .Replace("@RAZAOSOCIALCLIENTE", salesOrder.razao_social)
                            .Replace("@CNPJCPFCLIENTE", salesOrder.cnpj_cpf_cliente)
                            .Replace("@DATAHORAABERTURAPEDIDO", salesOrder.data_hora_abertura_pedido.ToString())
                            .Replace("@DATAHORAFECHAMENTOPEDIDO", salesOrder.data_hora_fechamento_pedido.ToString())
                            .Replace("@NUMEROPEDIDOCLIENTE", salesOrder.numero_pedido_cliente)
                            .Replace("@DATAENTREGAPEDIDO", salesOrder.data_entrega_pedido.ToString())
                            .Replace("@CODIGOUNIDADEPEDIDO", salesOrder.codigo_unidade_pedido)
                            .Replace("@CODIGOUNIDADENFPEDIDO", salesOrder.codigo_unidade_nf_pedido)
                            .Replace("@CODIGOUNIDADERETIRADAPEDIDO", salesOrder.codigo_unidade_retirada_pedido)
                            .Replace("@VALORFRETEPEDIDO", salesOrder.valor_frete_pedido.ToString())
                            .Replace("@CODIGOCOBRANCAPEDIDO", salesOrder.codigo_cobranca_pedido)
                            .Replace("@CODIGOPLANPAGAMENTOPEDIDO", salesOrder.codigo_plan_pagamento_pedido)
                            .Replace("@CONDICAOVENDAPEDIDO", salesOrder.condicao_venda_pedido)
                            .Replace("@OBSERVACAOPEDIDO", salesOrder.observacao_pedido)
                            .Replace("@OBSERVACAOENTREGAPEDIDO", salesOrder.observacao_entrega_pedido)
                            .Replace("@FRETEDESPACHOPEDIDO", salesOrder.frete_despacho_pedido)
                            .Replace("@FRETEREDEDESPACHOPEDIDO", salesOrder.frete_rede_despacho_pedido)
                            .Replace("@CODIGOFORNECEDORFRETEPEDIDO", salesOrder.codigo_fornecedor_frete_pedido)
                            .Replace("@PRAZO1PEDIDO", salesOrder.prazo1_pedido.ToString())
                            .Replace("@PRAZO2PEDIDO", salesOrder.prazo2_pedido.ToString())
                            .Replace("@PRAZO3PEDIDO", salesOrder.prazo3_pedido.ToString())
                            .Replace("@PRAZO4PEDIDO", salesOrder.prazo4_pedido.ToString())
                            .Replace("@PRAZO5PEDIDO", salesOrder.prazo5_pedido.ToString())
                            .Replace("@PRAZO6PEDIDO", salesOrder.prazo6_pedido.ToString())
                            .Replace("@PRAZO7PEDIDO", salesOrder.prazo7_pedido.ToString())
                            .Replace("@PRAZO8PEDIDO", salesOrder.prazo8_pedido.ToString())
                            .Replace("@PRAZO9PEDIDO", salesOrder.prazo9_pedido.ToString())
                            .Replace("@PRAZO10PEDIDO", salesOrder.prazo10_pedido.ToString())
                            .Replace("@PRAZO11PEDIDO", salesOrder.prazo11_pedido.ToString())
                            .Replace("@PRAZO12PEDIDO", salesOrder.prazo12_pedido.ToString())
                            .Replace("@ORIGEMPEDIDO", salesOrder.origem_pedido)
                            .Replace("@NUMEROPEDIDOCOMPRADOR", salesOrder.numero_pedido_comprador)
                            .Replace("@POSICAOATUALPEDIDO", salesOrder.posicao_atual_pedido)
                            .Replace("@SALDOATUALRCA", salesOrder.saldo_atual_rca.ToString())
                            .Replace("@TIPOPRIORIDADEENTREGAPEDIDO", salesOrder.tipo_prioridade_entrega_pedido)
                            .Replace("@PERCDESCABATIMENTOPEDIDO", salesOrder.perc_desc_abatimento_pedido.ToString())
                            .Replace("@CUSTOBONIFICACAOPEDIDO", salesOrder.custo_bonificacao_pedido)
                            .Replace("@CODFORNECBONIFICACAOPEDIDO", salesOrder.cod_fornec_bonificacao_pedido)
                            .Replace("@CODIGOBONIFICAOPEDIDO", salesOrder.codigo_bonificao_pedido)
                            .Replace("@AGRUPAMENTOPEDIDO", salesOrder.agrupamento_pedido)
                            .Replace("@CODIGOENDERECOENTREGAPEDIDO", salesOrder.codigo_endereco_entrega_pedido)
                            .Replace("@ORCAMENTOPEDIDO", salesOrder.orcamento_pedido)
                            .Replace("@VALORDESCONTOABATIMENTOPEDIDO", salesOrder.valor_desconto_abatimento_pedido.ToString())
                            .Replace("@VALORENTRADAPEDIDO", salesOrder.valor_entrada_pedido.ToString())
                            .Replace("@STATUSPEDIDO", salesOrder.status_pedido)
                            .Replace("@TOTALITENSPEDIDO", salesOrder.total_itens_pedido.ToString())
                            .Replace("@TOTALPEDIDO", salesOrder.total_pedido.ToString())
                            .Replace("@TOTPEDIDOCOMIMPOSTO", salesOrder.total_pedido_com_imposto.ToString())
                            .Replace("@OBSERVACAORETORNO", salesOrder.observacao_retorno)
                            .Replace("@SALDOVERBA", salesOrder.saldo_verba.ToString())
                            .Replace("@QBPEDFRETE", salesOrder.quebra_pedido_frete)
                            .Replace("@PERCENTUALFRETEOUTRAFILIAL", salesOrder.percentual_frete_outra_filial.ToString())
                            .Replace("@CODIGO_FILIAL_PEDIDO_FRETE", salesOrder.codigo_filial_pedido_frete)
                            .Replace("@CODIGO_PRODUTO_PEDIDO_FRETE", salesOrder.codigo_produto_pedido_frete)
                            .Replace("@PRECO_PRODUTO_PEDIDO_FRETE", salesOrder.preco_produto_pedido_frete.ToString())
                            .Replace("@CODIGO_PEDIDORCA_PEDIDO_FRETE", salesOrder.codigo_pedido_rca_pedido_frete.ToString())
                            .Replace("@CIDADECLIENTE", salesOrder.cidade_cliente)
                            .Replace("@TIPOEMISSAO", salesOrder.tipo_emissao.ToString())
                            .Replace("@QB_PEDIDO_PRE_VENDA", salesOrder.quebra_pedido_pre_venda)
                            .Replace("@CODIGO_PEDIDO_RCA_PEDIDO_PRE_VENDA", salesOrder.codigo_pedido_rca_pedido_pre_venda)
                            .Replace("@CODIGOFILIALPEDIDOPRE_VENDA", salesOrder.codigo_filial_pedido_pre_venda)
                            .Replace("@RETORNONUMEROPEDIDOERP", salesOrder.retorno_numero_pedido_erp.ToString())
                            .Replace("@RETORNOMOTIVOBLOQUEIO", salesOrder.retorno_motivo_bloqueio)
                            .Replace("@RETORNOVALORPEDIDO", salesOrder.retorno_valor_pedido.ToString())
                            .Replace("@RETORNOVALORATENDIDO", salesOrder.retorno_valor_atendido.ToString())
                            .Replace("@NUMEROPEDIDOVENDA", salesOrder.numero_pedido_venda)
                            .Replace("@DATAEMISSAOMAPA", salesOrder.data_emissao_mapa)
                            .Replace("@NUMEROPEDIDOERPORIGINAL", salesOrder.numero_pedido_erp_origional.ToString())
                            .Replace("@COMISSAO", salesOrder.comissao.ToString())
                            .Replace("@PESO", salesOrder.peso.ToString())
                            .Replace("@GEROUBRINDE", salesOrder.gerou_brinde)
                            .Replace("@CODIGOMOTORISTA", salesOrder.codigo_motorista)
                            .Replace("@NOMEMOTORISTA", salesOrder.nome_motorista)
                            .Replace("@CELULARMOTORISTA", salesOrder.celular_motorista)
                            .Replace("@DATACADASTRO", salesOrder.data_cadastro.ToString())
                            .Replace("@STATUSPROCESSAMENTO", salesOrder.status_processamento)
                            .Replace("@DATAPROCESSAMENTO", salesOrder.data_processamento.HasValue ? salesOrder.data_processamento.Value.ToString() : "NULL")
                            .Replace("@MENSAGEMPROCESSAMENTO", salesOrder.mensagem_processamento)
                            .Replace("@NOMEARQUIVOREMESSA", salesOrder.nome_arquivo_remessa)
                            .Replace("@IDUSUARIO", salesOrder.id_usuario.ToString())
                            .Replace("@ENDERECOCLIENTE", salesOrder.endereco_cliente);

            var sqlfull = sqlInsert + " " + sqlValue;

            await _dbConnection.ExecuteAsync(sqlfull);
            

            foreach (var salesOrderItem in salesOrder.itens)
            {
                var sqlitemValue = SqlQueries.SalesInsertItens.Replace("@CODIGOPEDIDORCA", codPedidoRCA.ToString())
                .Replace("@CODIGORCA", salesOrderItem.codigo_rca.ToString())
                .Replace("@DATAHORAABERTURAPEDIDO", salesOrderItem.data_hora_abertura_pedido.ToString())
                .Replace("@ITEM", salesOrderItem.Item.ToString())
                .Replace("@CODIGOPRODUTO", salesOrderItem.codigo_produto)
                .Replace("@DESCRICAOPRODUTO", salesOrderItem.descricao_produto)
                .Replace("@QUANTIDADE", salesOrderItem.quantidade.ToString())
                .Replace("@PRC_VENDA_ORIGINAL", salesOrderItem.preco_venda_original.ToString())
                .Replace("@PRECOVENDA", salesOrderItem.preco_venda.ToString())
                .Replace("@CODIGOBARRAS", salesOrderItem.codigo_barras)
                .Replace("@QTEFATURADA", salesOrderItem.quantidade_faturada.ToString())
                .Replace("@BONIFICACAO", salesOrderItem.bonificacao)
                .Replace("@CODIGOCOMBO", salesOrderItem.codigo_combo.ToString())
                .Replace("@CORTE", salesOrderItem.corte)
                .Replace("@PERC_DESC", salesOrderItem.percentual_desconto.ToString())
                .Replace("@PERC_DSC_BOLET", salesOrderItem.percnetual_desconto_boleto.ToString())
                .Replace("@SUGESTAO", salesOrderItem.sugestao)
                .Replace("@CODIGOPEDIDO", salesOrderItem.codigo_pedido.ToString())
                .Replace("@PRC_VENDA_DESC", salesOrderItem.preco_venda_desconto.ToString())
                .Replace("@VALORTOTAL", salesOrderItem.valor_total.ToString())
                .Replace("@VALOR_TOTAL_COM_IMPOSTO", salesOrderItem.valor_total_com_imposto.ToString())
                .Replace("@CODIGODESCONTO3306", salesOrderItem.codigo_desconto3306)
                .Replace("@DESCRICAODESCONTO3306", salesOrderItem.descricao_desconto3306)
                .Replace("@COD_PRD_PRINC", salesOrderItem.codigo_produto_principal)
                .Replace("@OBSERVACAORETORNO", salesOrderItem.observacao_retorno)
                .Replace("@CODIGOUNIDADERETIRA", salesOrderItem.codigo_unidade_retirada)
                .Replace("@TIPOENTREGA", salesOrderItem.tipo_entrega)
                .Replace("@CODIGODESCONTO561", salesOrderItem.codigo_desconto561)
                .Replace("@DIFERENCAPRECO", salesOrderItem.diferenca_preco.ToString())
                .Replace("@SALDOVERBA", salesOrderItem.saldo_verba.ToString())
                .Replace("@BASECREDDEBRCADESCONTO561", salesOrderItem.base_cred_deb_rca_descont561)
                .Replace("@APLICAAUTOMATICODESCONTO561", salesOrderItem.aplica_automatico_desconto561)
                .Replace("@PERCENTUALDESCONTO561", salesOrderItem.percentual_desconto561.ToString())
                .Replace("@CODIGOAUXILIAREMBALAGEM", salesOrderItem.codigo_auxiliar_embalagem)
                .Replace("@QDEUNITARIAEMBALAGEM", salesOrderItem.quantidade_unitaria_embalagem.ToString())
                .Replace("@UTILIZAVENDAPOREMBALAGEM", salesOrderItem.utiliza_venda_por_embalagem)
                .Replace("@TIPOCARGAPRODUTO", salesOrderItem.tipo_carga_produto)
                .Replace("@EXIBECOMBOEMBALAGEM", salesOrderItem.exibe_combo_embalagem)
                .Replace("@ITNEGOC", salesOrderItem.item_negociado)
                .Replace("@UNIDADEVENDA", salesOrderItem.unidade_venda)
                .Replace("@TIPOESTOQUEPRODUTO", salesOrderItem.tipo_estoque_produto)
                .Replace("@CODIGOREGIAO", salesOrderItem.codigo_regiao.ToString())
                .Replace("@PERCENTUALACRESCIMO", salesOrderItem.percentual_acrescimo.ToString())
                .Replace("@COMISSAO", salesOrderItem.comissao.ToString())
                .Replace("@PESO", salesOrderItem.peso.ToString())
                .Replace("@VLR_ST", salesOrderItem.valor_st.ToString())
                .Replace("@PRC_COM_ST", salesOrderItem.preco_st.ToString())
                .Replace("@VL_TOT_COM_ST", salesOrderItem.valor_total_com_st.ToString())
                .Replace("@NUMEROCARREGAMENTO", salesOrderItem.numero_carregamento.ToString())
                .Replace("@PERCENTUALBASERED", salesOrderItem.percentual_base_red.ToString())
                .Replace("@PERCENTUALICM", salesOrderItem.percentual_icm.ToString())
                .Replace("@DATAVALIDADECAMPANHASHELF", salesOrderItem.data_validade_campanha_shelf)
                .Replace("@PRECOCAMPANHASHELF", salesOrderItem.preco_campanha_shelf.ToString())
                .Replace("@CODIGOCAMPANHASHELF", salesOrderItem.codigo_campanha_shelf)
                .Replace("@UNIDADEFRIOS", salesOrderItem.unidade_frios);                

                await _dbConnection.ExecuteAsync(sqlitemValue);
            }

            var pedido = await GetSalesFullRepositoryAsync(codPedidoRCA.ToString());

            salesOrder.data_hora_abertura_pedido = pedido.datahoraaberturapedido;

            salesOrder.codigo_pedido_rca = pedido.codigopedidorca;

            return salesOrder;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<int> UpdateSalesAsync(SalesOrder salesOrder)
    {
        try
        {
            string sql = SqlQueries.SalesUpdate;
            var result = await _dbConnection.ExecuteAsync(sql, salesOrder);
            return result;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public async Task<int> DeleteSalesAsync(string codpedidorca)
    {
        try
        {
            string sql = SqlQueries.SalesDelete;
            var result = await _dbConnection.ExecuteAsync(sql, new { CODIGOPEDIDORCA = codpedidorca });
            return result;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    private async Task<int> NumeroPedidoRCA(string userid)
    {
        var sql = SqlQueries.NumeroPedidoRca.Replace("@IDUSUARIO", userid);
        var result = await _dbConnection.QueryFirstOrDefaultAsync<int>(sql);

        return result;
    }

    public async Task RulesSalesSoap(int codigoPedidoRCA, int codigoRCA, string dataHoraAbertura)
    {
        HttpClient httpClient = new HttpClient
        {
            Timeout = TimeSpan.FromMilliseconds(100500)
        };

        string soapRequest =
            $@"<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:tem=""http://tempuri.org/"">
                <soapenv:Header/>
                <soapenv:Body>
                    <tem:ProcessarPedidosTabela>
                        <tem:jsonProcessarPedidoCommand>{{""Licenca"":""2023DELLYS"",""Pedidos"":[{{""CodigoPedidoRCA"":{codigoPedidoRCA},""CodigoRCA"":{codigoRCA},""DataHoraAbertura"":""{dataHoraAbertura}""}}]}}</tem:jsonProcessarPedidoCommand>
                    </tem:ProcessarPedidosTabela>
                </soapenv:Body>
            </soapenv:Envelope>";

        HttpRequestMessage request = new HttpRequestMessage
        {
            RequestUri = new Uri("http://10.100.71.24:8975/WebService/SGMBusiness.asmx"),
            Method = HttpMethod.Post,
            Content = new StringContent(soapRequest, Encoding.UTF8, "text/xml")
        };
        request.Headers.Add("SOAPAction", "http://tempuri.org/ProcessarPedidosTabela");

        HttpResponseMessage response = await httpClient.SendAsync(request);


        if (response.IsSuccessStatusCode)
        {
            string soapResponse = await response.Content.ReadAsStringAsync();

            ProcessarPedidosTabelaResponseBody envelope;
            using (TextReader reader = new StringReader(soapResponse))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(ProcessarPedidosTabelaResponseBody));
                //envelope = (ProcessarPedidosTabelaResponseBody)serializer.Deserialize(reader);
            }
        }
        else
        {
            throw new Exception($"Failed to call the SOAP service. StatusCode: {response.StatusCode}");
        }
    }

    public Task<SalesOrder> InsertSalesAsync(TabPedido pedido)
    {
        throw new NotImplementedException();
    }
}

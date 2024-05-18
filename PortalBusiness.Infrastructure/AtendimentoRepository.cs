using Dapper;
using PortalBusiness.Domain.Entities;
using PortalBusiness.Domain.Models.Parameters;
using PortalBusiness.Infrastructure.Data.Queries;
using PortalBusiness.Infrastructure.Interfaces;
using System.Data;

namespace PortalBusiness.Infrastructure;

public class AtendimentoRepository : IAtendimentoRepository
{
    private readonly IDbConnection _dbConnection;
    public AtendimentoRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public async Task<IEnumerable<Atendimento>> GetAtendimentoRepositoryAsync(Parameters parameters)
    {
        try
        {
            string sql = SqlQueries.Atendimento.Replace("@CODIGOCLIENTE", parameters.Id.ToString())
                                               .Replace("@CODIGOUNIDADE", parameters.CodigoUnidade.ToString());

            var sqlCardDevolucao = SqlQueries.CardDevolucao.Replace("@CODIGOCLIENTE", parameters.Id.ToString())
                                                           .Replace("@CODIGOUNIDADE", parameters.CodigoUnidade.ToString());

            var sqlVendas = SqlQueries.HistoricoVendas.Replace("@CODIGOCLIENTE", parameters.Id.ToString())
                                                      .Replace("@CODIGOUNIDADE", parameters.CodigoUnidade.ToString())
                                                      .Replace("@CODIGORCA", parameters.CodigoRca.ToString());

            var sqlPedido = SqlQueries.HistoricoPedidos.Replace("@CODIGOCLIENTE", parameters.Id.ToString())
                                                       .Replace("@CODIGOUNIDADE", parameters.CodigoUnidade.ToString())
                                                       .Replace("@CODIGORCA", parameters.CodigoRca.ToString());

            var sqlPedidoItem = SqlQueries.HistoricoPedidosItens.Replace("@CODIGOCLIENTE", parameters.Id.ToString())
                                                           .Replace("@CODIGOUNIDADE", parameters.CodigoUnidade.ToString());

            var sqlOportunidades = SqlQueries.Oportunidades.Replace("@CODIGOCLIENTE", parameters.Id.ToString())
                                                           .Replace("@CODIGOUNIDADE", parameters.CodigoUnidade.ToString())
                                                           .Replace("@CODIGORCA", parameters.CodigoRca.ToString());

            var sqlTitulos = SqlQueries.Titulos.Replace("@CODIGOCLIENTE", parameters.Id.ToString())
                                               .Replace("@CODIGOUNIDADE", parameters.CodigoUnidade.ToString());

            var sqlDevolucao = SqlQueries.Devolucoes.Replace("@CODIGOCLIENTE", parameters.Id.ToString())
                                               .Replace("@CODIGOUNIDADE", parameters.CodigoUnidade.ToString());

            var sqlMixIdeal = SqlQueries.MixIdeal.Replace("@CODIGOCLIENTE", parameters.Id.ToString())
                                                .Replace("@CODIGOUNIDADE", parameters.CodigoUnidade.ToString());


            var result = await _dbConnection.QueryAsync<Atendimento>(sql, parameters);

            var cardDevolucao = await _dbConnection.QueryAsync<CardDevolucao>(sqlCardDevolucao, parameters);            

            var vendas = await _dbConnection.QueryAsync<Vendas>(sqlVendas, parameters);

            var pedidos = await _dbConnection.QueryAsync<HistoricoPedido>(sqlPedido, parameters);

            var oportunidades = await _dbConnection.QueryAsync<Oportunidade>(sqlOportunidades, parameters);

            var titulos = await _dbConnection.QueryAsync<Titulo>(sqlTitulos, parameters);

            var devolucao = await _dbConnection.QueryAsync<Devolucao>(sqlDevolucao, parameters);

            var mixIdeals = await _dbConnection.QueryAsync<MixIdeal>(sqlMixIdeal, parameters);

            if (result != null && result.Any())
            {
                if (cardDevolucao != null && cardDevolucao.Any())
                {
                    foreach (var item in result)
                    {
                        item.CardDevolucao = cardDevolucao.ToList();
                    }
                }

                if (vendas != null && vendas.Any())
                {
                    foreach (var atendimento in result)
                    {
                        var resultVendas = vendas.FirstOrDefault();
                        atendimento.vendas = resultVendas;
                       
                    }
                }
                else
                {
                    foreach (var ven in result)
                    {
                        var vendasNula = new Vendas();
                        vendasNula.valor_venda_01 = 0;
                        vendasNula.valor_venda_02 = 0;
                        vendasNula.valor_venda_03 = 0;
                        vendasNula.valor_venda_04 = 0;
                        vendasNula.valor_venda_05 = 0;
                        vendasNula.valor_venda_06 = 0;
                        vendasNula.valor_venda_07 = 0;
                        vendasNula.valor_venda_08 = 0;
                        vendasNula.valor_venda_09 = 0;
                        vendasNula.valor_venda_10 = 0;
                        vendasNula.valor_venda_11 = 0;
                        vendasNula.valor_venda_12 = 0;
                        vendasNula.valor_venda_total = 0;

                        ven.vendas = vendasNula;
                    }
                }

                if (oportunidades != null && oportunidades.Any())
                {
                    foreach (var item in result)
                    {
                        item.oportunidades = oportunidades.ToList();
                    }
                }

                if (titulos != null && titulos.Any())
                {
                    foreach (var item in result)
                    {
                        item.Titulos = titulos.ToList();
                    }
                }

                if (devolucao != null && devolucao.Any())
                {
                    foreach (var item in result)
                    {
                        item.Devolucoes = devolucao.ToList();
                    }
                }

                if (mixIdeals != null && mixIdeals.Any())
                {
                    foreach (var item in result)
                    {
                        item.MixIdealItens = mixIdeals.ToList();
                    }
                }

                if (pedidos != null && pedidos.Any())
                {
                    foreach (var atendimento in result)
                    {
                        atendimento.pedidos = pedidos.ToList();
                        foreach (var pedido in atendimento.pedidos)
                        {
                            var pedidoItens = await _dbConnection.QueryAsync<HistoricoPedidoItem>(
                                sqlPedidoItem.Replace("@NUMEROPEDIDO", pedido.NumeroPedido.ToString())
                            );

                            pedido.Itens = pedidoItens.ToList();
                        }
                    }
                }

            }

            return result;
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }
}

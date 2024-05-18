using Newtonsoft.Json;

namespace PortalBusiness.Domain.Entities;

public class Payment
{
    [JsonProperty("codigo_plano_pagamento")]
    public double CODIGOPLANOPAGAMENTO { get; set; }

    [JsonProperty("descricao_plano_pagamento")]
    public string DESCRICAOPLANOPAGAMENTO { get; set; }

    [JsonProperty("numero_dias_plano_pagamento")]
    public double NUMERODIASPLANOPAGAMENTO { get; set; }

    [JsonProperty("data_vencimento1_plano_pagamento")]
    public DateTime DATAVENCIMENTO1PLANOPAGAMENTO { get; set; }

    [JsonProperty("data_vencimento2_plano_pagamento")]
    public DateTime DATAVENCIMENTO2PLANOPAGAMENTO { get; set; }

    [JsonProperty("data_vencimento3_plano_pagamento")]
    public DateTime DATAVENCIMENTO3PLANOPAGAMENTO { get; set; }

    [JsonProperty("prazo1_plano_pagamento")]
    public double PRAZO1PLANOPAGAMENTO { get; set; }
    [JsonProperty("prazo2_plano_pagamento")]
    public double PRAZO2PLANOPAGAMENTO { get; set; }
    [JsonProperty("prazo3_plano_pagamento")]
    public double PRAZO3PLANOPAGAMENTO { get; set; }
    [JsonProperty("prazo4_plano_pagamento")]
    public double PRAZO4PLANOPAGAMENTO { get; set; }
    [JsonProperty("prazo5_plano_pagamento")]
    public double PRAZO5PLANOPAGAMENTO { get; set; }
    [JsonProperty("prazo6_plano_pagamento")]
    public double PRAZO6PLANOPAGAMENTO { get; set; }
    [JsonProperty("prazo7_plano_pagamento")]
    public double PRAZO7PLANOPAGAMENTO { get; set; }
    [JsonProperty("prazo8_plano_pagamento")]
    public double PRAZO8PLANOPAGAMENTO { get; set; }
    [JsonProperty("prazo9_plano_pagamento")]
    public double PRAZO9PLANOPAGAMENTO { get; set; }
    [JsonProperty("prazo10_plano_pagamento")]
    public double PRAZO10PLANOPAGAMENTO { get; set; }
    [JsonProperty("prazo11_plano_pagamento")]
    public double PRAZO11PLANOPAGAMENTO { get; set; }
    [JsonProperty("prazo12_plano_pagamento")]
    public double PRAZO12PLANOPAGAMENTO { get; set; }

    [JsonProperty("valor_minimo_plano_pagamento")]
    public double VALORMINIMOPLANOPAGAMENTO { get; set; }

    [JsonProperty("codigo_tabela_preco")]
    public double CODIGOTABELAPRECO { get; set; }

    [JsonProperty("tipo_restricao_plano_pagamento")]
    public string TIPORESTRICAOPLANOPAGAMENTO { get; set; }

    [JsonProperty("codigo_restricao_plano_pagamento")]
    public double CODIGORESTRICAOPLANOPAGAMENTO { get; set; }

    [JsonProperty("tipo_venda_plano_pagamento")]
    public string TIPOVENDAPLANOPAGAMENTO { get; set; }

    [JsonProperty("margem_minima_plano_pagamento")]
    public string MARGEMMINIMAPLANOPAGAMENTO { get; set; }

    [JsonProperty("acrescimo_desconto_maximo")]
    public double ACRESCIMODESCONTOMAXIMO { get; set; }

    [JsonProperty("tipo_prazo_plano_pagamento")]
    public string TIPOPRAZOPLANOPAGAMENTO { get; set; }

    [JsonProperty("codigo_unidade")]
    public string CODIGOUNIDADE { get; set; }

    [JsonProperty("tipo_entrada_plano_pagamento")]
    public double TIPOENTRADAPLANOPAGAMENTO { get; set; }

    [JsonProperty("venda_boleto_plano_pagamento")]
    public string VENDABOLETOPLANOPAGAMENTO { get; set; }

    [JsonProperty("forma_parcela_plano_pagamento")]
    public string FORMAPARCELAPLANOPAGAMENTO { get; set; }

    [JsonProperty("valor_min_parcela_plano_pagamento")]
    public double VALORMINPARCELAPLANOPAGAMENTO { get; set; }

    [JsonProperty("dias_min_parcela_plano_pagamento")]
    public double DIASMINPARCELAPLANOPAGAMENTO { get; set; }

    [JsonProperty("dias_max_parcela_plano_pagamento")]
    public double DIASMAXPARCELAPLANOPAGAMENTO { get; set; }

    [JsonProperty("qtd_parcela_plano_pagamento")]
    public double QTDPARCELAPLANOPAGAMENTO { get; set; }

    [JsonProperty("qtd_minima_de_itens_plano_pagamento")]
    public double QTDMINIMADEITENSPLANOPAGAMENTO { get; set; }

    [JsonProperty("usaplanofv")]
    public string USAPLANOFV { get; set; }
}

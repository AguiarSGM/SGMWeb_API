using Newtonsoft.Json;

namespace PortalBusiness.Domain.Entities.Products;

public class ProductsOffersOut
{
    [JsonProperty("codigo_desconto")]
    public int CodigoDesconto { get; set; }

    [JsonProperty("codigo_cliente")]
    public int CodigoCliente { get; set; }

    [JsonProperty("codigo_departamento")]
    public int Codigodepartamento { get; set; }

    [JsonProperty("codigo_sessao")]
    public int Codigosecao { get; set; }

    [JsonProperty("codigo_categoria")]
    public int Codigocategoria { get; set; }

    [JsonProperty("codigo_produto")]
    public int Codigoproduto { get; set; }

    [JsonProperty("percentual_desconto")]
    public double Percentualdesconto { get; set; }

    [JsonProperty("data_inicio")]
    public DateTime Datainicio { get; set; }

    [JsonProperty("data_fim")]
    public DateTime Datafim { get; set; }

    [JsonProperty("codigo_usuario")]
    public int Codigousuario { get; set; }

    [JsonProperty("codigo_plano_pagamento")]
    public int Codigoplanopagamento { get; set; }

    [JsonProperty("base_cred_deb_rca")]
    public string Basecreddebrca { get; set; }

    [JsonProperty("utiliza_desc_rede")]
    public string Utilizadescrede { get; set; }

    [JsonProperty("codigo_fornecedor")]
    public double Codigofornecedor { get; set; }

    [JsonProperty("codigo_supervisor")]
    public int Codigosupervisor { get; set; }

    [JsonProperty("tipo_venda")]
    public string Tipovenda { get; set; }

    [JsonProperty("codigo_regiao")]
    public int Codigoregiao { get; set; }

    [JsonProperty("cod_func_lanc")]
    public int Codfunclanc { get; set; }

    [JsonProperty("data_lancamento")]
    public DateTime Datalancamento { get; set; }

    [JsonProperty("cod_func_ult_alter")]
    public int Codfuncultalter { get; set; }

    [JsonProperty("data_ult_alter")]
    public DateTime Dataultalter { get; set; }

    [JsonProperty("uf")]
    public string Uf { get; set; }

    [JsonProperty("codigo_atividade")]
    public int Codigoatividade { get; set; }

    [JsonProperty("origem_pedido")]
    public string Origempedido { get; set; }

    [JsonProperty("codigo_praca")]
    public int Codigopraca { get; set; }

    [JsonProperty("codigo_produto_principal")]
    public int Codigoprodutoprincipal { get; set; }

    [JsonProperty("num_rca")]
    public int Numorca { get; set; }

    [JsonProperty("class_venda")]
    public string Classevenda { get; set; }

    [JsonProperty("aplicacao_desconto")]
    public string Aplicadesconto { get; set; }

    [JsonProperty("tipo_carga")]
    public string Tipocarga { get; set; }

    [JsonProperty("credita_sobre_politica")]
    public string Creditasobrepolitica { get; set; }

    [JsonProperty("tipo")]
    public string Tipo { get; set; }

    [JsonProperty("perc_desc_fin")]
    public double Percdescfin { get; set; }

    [JsonProperty("altera_ptabela")]
    public string Alteraptabela { get; set; }

    [JsonProperty("tipo_aplic_desconto_cb")]
    public string Tipoaplicdescontocb { get; set; }

    [JsonProperty("codigo_produto_cb")]
    public int Codigoprodutocb { get; set; }

    [JsonProperty("perc_com_profissional_minimo")]
    public double Perccomprofissionalminimo { get; set; }

    [JsonProperty("perc_desc_fornec")]
    public double Percdescfornec { get; set; }

    [JsonProperty("prioritaria")]
    public string Prioritaria { get; set; }

    [JsonProperty("questiona_uso_prioritaria")]
    public string Questionausoprioritaria { get; set; }

    [JsonProperty("area_atuacao")]
    public string Areaatuacao { get; set; }

    [JsonProperty("codigo_unidade")]
    public string Codigounidade { get; set; }

    [JsonProperty("qtd_maxima_politica")]
    public double Qtdemaximapolitica { get; set; }

    [JsonProperty("qtd_maxima_pedido")]
    public double Qtdemaximapedido { get; set; }

    [JsonProperty("codigo_grupo")]
    public int Codigogrupo { get; set; }

    [JsonProperty("apenas_plano_pagamento_maximo")]
    public string Apenasplanopagamentomaximo { get; set; }

    [JsonProperty("per_com_min_t")]
    public double Percommint { get; set; }

    [JsonProperty("per_com_rep_t")]
    public double Percomrep { get; set; }

    [JsonProperty("per_com_ext_t")]
    public double Percomext { get; set; }

    [JsonProperty("aplica_desc_simples_nacional")]
    public string Aplicadescsimplesnacional { get; set; }

    [JsonProperty("obs_desconto")]
    public string Obsdesconto { get; set; }

    [JsonProperty("codigo_marca")]
    public int Codigomarca { get; set; }

    [JsonProperty("codigo_rede")]
    public int Codigorede { get; set; }

    [JsonProperty("tipo_fv")]
    public string Tipofv { get; set; }

    [JsonProperty("codigo_condicao_venda")]
    public int Codigocondicaovenda { get; set; }

    [JsonProperty("prioritaria_geral")]
    public string Prioritariageral { get; set; }

    [JsonProperty("considera_calc_giro_medic")]
    public string Consideracalcgiromedic { get; set; }

    [JsonProperty("tipo_fj")]
    public string Tipofj { get; set; }

    [JsonProperty("num_rolo")]
    public string Numrolo { get; set; }

    [JsonProperty("codigo_identificador")]
    public int Codigoidentificador { get; set; }

    [JsonProperty("conceder_maior_comiss_reg")]
    public string Concedermaiorcomissreg { get; set; }

    [JsonProperty("preco_fixo")]
    public double Precofixo { get; set; }

    [JsonProperty("codigo_cliente_conv")]
    public double Codigoclienteconv { get; set; }

    [JsonProperty("qtd_min_desconto")]
    public double Qtdemindesconto { get; set; }

    [JsonProperty("subcategoria")]
    public double Subcategoria { get; set; }

    [JsonProperty("fiscal_caixa")]
    public string Fiscalcaixa { get; set; }

    [JsonProperty("codigo_linha_produto")]
    public int Codigolinhaproduto { get; set; }

    [JsonProperty("codigo_promocao_med")]
    public int Codigopromocaomed { get; set; }

    [JsonProperty("prazo_maximo_venda")]
    public double Prazomaximovenda { get; set; }

    [JsonProperty("codigo_func")]
    public int Codigofunc { get; set; }

    [JsonProperty("perc_desc_max")]
    public double Percdescmax { get; set; }

    [JsonProperty("qtde_inicio")]
    public double Qtdeinicio { get; set; }

    [JsonProperty("qtde_fim")]
    public double Qtdefim { get; set; }

    [JsonProperty("codigo_grupo_rest")]
    public int Codigogruporest { get; set; }

    [JsonProperty("tipo_grupo_rest")]
    public string Tipogruporest { get; set; }

    [JsonProperty("codigo_cobranca")]
    public string Codigocobranca { get; set; }

    [JsonProperty("valor_minimo")]
    public double Valorminimo { get; set; }

    [JsonProperty("valor_maximo")]
    public double Valormaximo { get; set; }

    [JsonProperty("tipo_desconto")]
    public string Tipodesconto { get; set; }

    [JsonProperty("codigo_auxiliar")]
    public int Codigoauxiliar { get; set; }

    [JsonProperty("per_desc_fornec")]
    public double Perdescfornec { get; set; }
}

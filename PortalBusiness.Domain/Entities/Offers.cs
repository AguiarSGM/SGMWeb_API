using Newtonsoft.Json;

namespace PortalBusiness.Domain.Entities;

public class Offers
{
    [JsonProperty("codigo_desconto")]
    public int codigoDesconto { get; set; }

    [JsonProperty("codigo_departamento")]
    public int codigodepartamento { get; set; }

    [JsonProperty("codigo_sessao")]
    public int codigosecao { get; set; }

    [JsonProperty("codigo_categoria")]
    public int codigocategoria { get; set; }

    [JsonProperty("codigo_produto")]
    public int codigoproduto { get; set; }

    [JsonProperty("percentual_desconto")]
    public decimal Percentualdesconto { get; set; }

    [JsonProperty("data_inicio")]
    public DateTime Datainicio { get; set; }

    [JsonProperty("data_fim")]
    public DateTime Datafim { get; set; }

    [JsonProperty("codigo_usuario")]
    public int codigousuario { get; set; }

    [JsonProperty("codigo_plano_pagamento")]
    public int codigoplanopagamento { get; set; }

    [JsonProperty("base_cred_deb_rca")]
    public string Basecreddebrca { get; set; }

    [JsonProperty("utiliza_desc_rede")]
    public string Utilizadescrede { get; set; }

    [JsonProperty("codigo_fornecedor")]
    public int codigofornecedor { get; set; }

    [JsonProperty("codigo_supervisor")]
    public int codigosupervisor { get; set; }

    [JsonProperty("tipo_venda")]
    public string Tipovenda { get; set; }

    [JsonProperty("codigo_regiao")]
    public int codigoregiao { get; set; }

    [JsonProperty("cod_func_lanc")]
    public double Codfunclanc { get; set; }

    [JsonProperty("data_lancamento")]
    public DateTime Datalancamento { get; set; }

    [JsonProperty("cod_func_ult_alter")]
    public double Codfuncultalter { get; set; }

    [JsonProperty("data_ult_alter")]
    public DateTime Dataultalter { get; set; }

    [JsonProperty("uf")]
    public string Uf { get; set; }

    [JsonProperty("codigo_atividade")]
    public int codigoatividade { get; set; }

    [JsonProperty("origem_pedido")]
    public string Origempedido { get; set; }

    [JsonProperty("codigo_praca")]
    public int codigopraca { get; set; }

    [JsonProperty("codigo_produto_principal")]
    public int codigoprodutoprincipal { get; set; }

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
    public decimal Percdescfin { get; set; }

    [JsonProperty("altera_ptabela")]
    public string Alteraptabela { get; set; }

    [JsonProperty("tipo_aplic_desconto_cb")]
    public string Tipoaplicdescontocb { get; set; }

    [JsonProperty("codigo_produto_cb")]
    public int codigoprodutocb { get; set; }

    [JsonProperty("perc_com_profissional_minimo")]
    public decimal Perccomprofissionalminimo { get; set; }

    [JsonProperty("perc_desc_fornec")]
    public decimal Percdescfornec { get; set; }

    [JsonProperty("prioritaria")]
    public string Prioritaria { get; set; }

    [JsonProperty("questiona_uso_prioritaria")]
    public string Questionausoprioritaria { get; set; }

    [JsonProperty("area_atuacao")]
    public string Areaatuacao { get; set; }

    [JsonProperty("codigo_unidade")]
    public string Codigounidade { get; set; }

    [JsonProperty("qtd_maxima_politica")]
    public int Qtdemaximapolitica { get; set; }

    [JsonProperty("qtd_maxima_pedido")]
    public int Qtdemaximapedido { get; set; }

    [JsonProperty("codigo_grupo")]
    public int codigogrupo { get; set; }

    [JsonProperty("apenas_plano_pagamento_maximo")]
    public string Apenasplanopagamentomaximo { get; set; }

    [JsonProperty("per_com_min_t")]
    public decimal Percommint { get; set; }

    [JsonProperty("per_com_rep_t")]
    public decimal Percomrep { get; set; }

    [JsonProperty("per_com_ext_t")]
    public decimal Percomext { get; set; }

    [JsonProperty("aplica_desc_simples_nacional")]
    public string Aplicadescsimplesnacional { get; set; }

    [JsonProperty("obs_desconto")]
    public string Obsdesconto { get; set; }

    [JsonProperty("codigo_marca")]
    public int codigomarca { get; set; }

    [JsonProperty("codigo_rede")]
    public int codigorede { get; set; }

    [JsonProperty("tipo_fv")]
    public string Tipofv { get; set; }

    [JsonProperty("codigo_condicao_venda")]
    public int codigocondicaovenda { get; set; }

    [JsonProperty("prioritaria_geral")]
    public string Prioritariageral { get; set; }

    [JsonProperty("considera_calc_giro_medic")]
    public string Consideracalcgiromedic { get; set; }

    [JsonProperty("tipo_fj")]
    public string Tipofj { get; set; }

    [JsonProperty("num_rolo")]
    public string Numrolo { get; set; }

    [JsonProperty("codigo_identificador")]
    public int codigoidentificador { get; set; }

    [JsonProperty("conceder_maior_comiss_reg")]
    public string Concedermaiorcomissreg { get; set; }

    [JsonProperty("preco_fixo")]
    public decimal Precofixo { get; set; }

    [JsonProperty("codigo_cliente_conv")]
    public int codigoclienteconv { get; set; }

    [JsonProperty("qtd_min_desconto")]
    public int Qtdemindesconto { get; set; }

    [JsonProperty("subcategoria")]
    public decimal Subcategoria { get; set; }

    [JsonProperty("fiscal_caixa")]
    public string Fiscalcaixa { get; set; }

    [JsonProperty("codigo_linha_produto")]
    public int codigolinhaproduto { get; set; }

    [JsonProperty("codigo_promocao_med")]
    public int codigopromocaomed { get; set; }

    [JsonProperty("prazo_maximo_venda")]
    public decimal Prazomaximovenda { get; set; }

    [JsonProperty("codigo_func")]
    public int codigofunc { get; set; }

    [JsonProperty("perc_desc_max")]
    public decimal Percdescmax { get; set; }

    [JsonProperty("qtde_inicio")]
    public int Qtdeinicio { get; set; }

    [JsonProperty("qtde_fim")]
    public int Qtdefim { get; set; }

    [JsonProperty("codigo_grupo_rest")]
    public int codigogruporest { get; set; }

    [JsonProperty("tipo_grupo_rest")]
    public string Tipogruporest { get; set; }

    [JsonProperty("codigo_cobranca")]
    public string Codigocobranca { get; set; }

    [JsonProperty("valor_minimo")]
    public decimal Valorminimo { get; set; }

    [JsonProperty("valor_maximo")]
    public decimal Valormaximo { get; set; }

    [JsonProperty("tipo_desconto")]
    public string Tipodesconto { get; set; }

    [JsonProperty("codigo_auxiliar")]
    public int codigoauxiliar { get; set; }

    [JsonProperty("per_desc_fornec")]
    public decimal Perdescfornec { get; set; }
}

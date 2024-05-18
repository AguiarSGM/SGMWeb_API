using Newtonsoft.Json;

namespace PortalBusiness.Domain.Entities;

public class ClientFull
{
    [JsonProperty("codigo_cliente")]
    public int codigocliente { get; set; }

    [JsonProperty("razao_social_cliente")]
    public string razaosocialcliente { get; set; }

    [JsonProperty("fantasia_cliente")]
    public string fantasiacliente { get; set; }

    [JsonProperty("telefone_comercial_cliente")]
    public string telefonecomercialcliente { get; set; }

    [JsonProperty("cnpj_cliente")]
    public string cnpjcliente { get; set; }

    [JsonProperty("inscricao_estadual_cliente")]
    public string inscricaoestadualcliente { get; set; }

    [JsonProperty("inscricao_municipal_cliente")]
    public string inscricaomunicipalcliente { get; set; }

    [JsonProperty("codigo_cnae_cliente")]
    public string codigocnaecliente { get; set; }

    [JsonProperty("codigo_atividade_cliente")]
    public int codigoatividadecliente { get; set; }

    [JsonProperty("contribuinte")]
    public string contribuinte { get; set; }

    [JsonProperty("simples_nacional_cliente")]
    public string simplesnacionalcliente { get; set; }

    [JsonProperty("tipo_pessoa_cliente")]
    public string tipopessoacliente { get; set; }

    [JsonProperty("email_cliente")]
    public string emailcliente { get; set; }

    [JsonProperty("email_nfe_cliente")]
    public string emailnfecliente { get; set; }

    [JsonProperty("codigo_cobranca_cliente")]
    public string codigocobrancacliente { get; set; }

    [JsonProperty("codigo_plano_pagamento_cliente")]
    public int codigoplanopagamentocliente { get; set; }

    [JsonProperty("limite_credito_cliente")]
    public decimal limitecreditocliente { get; set; }

    [JsonProperty("saldo_limite_cliente")]
    public decimal saldolimitecliente { get; set; }

    [JsonProperty("data_vencimento_limite_cliente")]
    public DateTime datavencimentolimitecliente { get; set; }

    [JsonProperty("credito_pendente_cliente")]
    public decimal creditopendentecliente { get; set; }

    [JsonProperty("debito_cliente")]
    public decimal debitocliente { get; set; }

    [JsonProperty("bloqueio_cliente")]
    public string bloqueiocliente { get; set; }

    [JsonProperty("data_bloqueio_cliente")]
    public DateTime databloqueiocliente { get; set; }

    [JsonProperty("monitorado_cliente")]
    public string monitoradocliente { get; set; }

    [JsonProperty("codigo_praca_cliente")]
    public int codigopracacliente { get; set; }

    [JsonProperty("nome_praca_cliente")]
    public string nomepracacliente { get; set; }

    [JsonProperty("regiao_cliente")]
    public string regiaocliente { get; set; }

    [JsonProperty("data_ultima_compra_cliente")]
    public DateTime dataultimacompracliente { get; set; }

    [JsonProperty("vip_cliente")]
    public string vipcliente { get; set; }

    [JsonProperty("classe_venda_cliente")]
    public string classevendacliente { get; set; }

    [JsonProperty("codigo_rede_cliente")]
    public int codigoredecliente { get; set; }

    [JsonProperty("observacao_gerencial1_cliente")]
    public string observacaogerencial1cliente { get; set; }

    [JsonProperty("observacao_entrega_cliente")]
    public string observacaoentregacliente { get; set; }

    [JsonProperty("endereco_comercial_cliente")]
    public string enderecocomercialcliente { get; set; }

    [JsonProperty("bairro_comercial_cliente")]
    public string bairrocomercialcliente { get; set; }

    [JsonProperty("cidade_comercial_cliente")]
    public string cidadecomercialcliente { get; set; }

    [JsonProperty("uf_comercial_cliente")]
    public string ufcomercialcliente { get; set; }

    [JsonProperty("numero_endereco_comercial_cliente")]
    public string numeroenderecocomercialcliente { get; set; }

    [JsonProperty("cep_comercial_cliente")]
    public string cepcomercialcliente { get; set; }

    [JsonProperty("endereco_entrega_cliente")]
    public string enderecoentregacliente { get; set; }

    [JsonProperty("bairro_entrega_cliente")]
    public string bairroentregacliente { get; set; }

    [JsonProperty("cidade_entrega_cliente")]
    public string cidadeentregacliente { get; set; }

    [JsonProperty("uf_entrega_cliente")]
    public string ufentregacliente { get; set; }

    [JsonProperty("numero_entrega_cliente")]
    public string numeroentregacliente { get; set; }

    [JsonProperty("cep_entrega_cliente")]
    public string cepentregacliente { get; set; }

    [JsonProperty("telefone_entrega_cliente")]
    public string telefoneentregacliente { get; set; }

    [JsonProperty("endereco_cobranca_cliente")]
    public string enderecocobrancacliente { get; set; }

    [JsonProperty("bairro_cobranca_cliente")]
    public string bairrocobrancacliente { get; set; }

    [JsonProperty("cidade_cobranca_cliente")]
    public string cidadecobrancacliente { get; set; }

    [JsonProperty("uf_cobranca_cliente")]
    public string ufcobrancacliente { get; set; }

    [JsonProperty("numero_cobranca_cliente")]
    public string numerocobrancacliente { get; set; }

    [JsonProperty("cep_cobranca_cliente")]
    public string cepcobrancacliente { get; set; }

    [JsonProperty("telefone_cobranca_cliente")]
    public string telefonecobrancacliente { get; set; }

    [JsonProperty("codigo_rca1_cliente")]
    public int codigorca1cliente { get; set; }

    [JsonProperty("alvara_cliente")]
    public string alvaracliente { get; set; }

    [JsonProperty("data_vencimento_alvara_cliente")]
    public DateTime datavencimentoalvaracliente { get; set; }

    [JsonProperty("observacao1_cliente")]
    public string observacao1cliente { get; set; }

    [JsonProperty("observacao2_cliente")]
    public string observacao2cliente { get; set; }

    [JsonProperty("percentual_descont1_cliente")]
    public string percentualdescont1cliente { get; set; }

    [JsonProperty("percentual_descont2_cliente")]
    public string percentualdescont2cliente { get; set; }

    [JsonProperty("codigo_rca2_cliente")]
    public int codigorca2cliente { get; set; }

    [JsonProperty("codigo_principal_cliente")]
    public int codigoprincipalcliente { get; set; }

    [JsonProperty("consumidor_final_cliente")]
    public string consumidorfinalcliente { get; set; }

    [JsonProperty("tipo_empresa_cliente")]
    public string tipoempresacliente { get; set; }

    [JsonProperty("observacao_gerencial2_cliente")]
    public string observacaogerencial2cliente { get; set; }

    [JsonProperty("observacao_gerencial3_cliente")]
    public string observacaogerencial3cliente { get; set; }

    [JsonProperty("prazo_medio_cliente")]
    public string prazomediocliente { get; set; }

    [JsonProperty("bloqueio_sefaz_cliente")]
    public string bloqueiosefazcliente { get; set; }

    [JsonProperty("codigo_cidade_cliente")]
    public int codigocidadecliente { get; set; }

    [JsonProperty("usa_deb_cred_rca")]
    public string usadebcredrca { get; set; }

    [JsonProperty("usa_desconto_icms")]
    public string usadescontoicms { get; set; }

    [JsonProperty("desc_produto")]
    public string descproduto { get; set; }

    [JsonProperty("frete_despacho")]
    public string fretedespacho { get; set; }

    [JsonProperty("plpagneg")]
    public string plpagneg { get; set; }

    [JsonProperty("emitedup")]
    public string emitedup { get; set; }

    [JsonProperty("perdesc")]
    public long perdesc { get; set; }

    [JsonProperty("perdesc2")]
    public long perdesc2 { get; set; }

    [JsonProperty("condvenda1")]
    public string condvenda1 { get; set; }

    [JsonProperty("condvenda5")]
    public string condvenda5 { get; set; }

    [JsonProperty("condvenda7")]
    public string condvenda7 { get; set; }

    [JsonProperty("condvenda10")]
    public string condvenda10 { get; set; }

    [JsonProperty("condvenda99")]
    public string condvenda99 { get; set; }

    [JsonProperty("condvenda14")]
    public string condvenda14 { get; set; }

    [JsonProperty("prazo_adicional")]
    public long prazoadicional { get; set; }

    [JsonProperty("perbasevend")]
    public long perbasevend { get; set; }

    [JsonProperty("percomcli")]
    public long percomcli { get; set; }

    [JsonProperty("calcula_st")]
    public string calculast { get; set; }

    [JsonProperty("cliente_fon_test")]
    public string clientefontest { get; set; }

    [JsonProperty("isento_icms")]
    public string isentoicms { get; set; }

    [JsonProperty("utiliza_ie_simplificada")]
    public string utilizaiesimplificada { get; set; }

    [JsonProperty("isento_ipi")]
    public string isentoipi { get; set; }

    [JsonProperty("cod_filial_nf")]
    public string codfilialnf { get; set; }

    [JsonProperty("aceita_venda_fracao")]
    public string aceitavendafracao { get; set; }

    [JsonProperty("valida_max_venda_pf")]
    public string validamaxvendapf { get; set; }

    [JsonProperty("valida_multiplo_venda")]
    public string validamultiplovenda { get; set; }

    [JsonProperty("valida_campanha_brinde")]
    public string validacampanhabrinde { get; set; }

    [JsonProperty("aceita_troca_negativa")]
    public string aceitatrocanegativa { get; set; }

    [JsonProperty("perde_sc_isento_icms")]
    public long perdescisentoicms { get; set; }

    [JsonProperty("tipo_desc_isencao")]
    public string Type_description_exemption { get; set; }
    public string tipodescisencao { get; set; }

    [JsonProperty("usa_iva_font_diferenciado")]
    public string usaivafontdiferenciado { get; set; }

    [JsonProperty("iva_fonte")]
    public string ivafonte { get; set; }

    [JsonProperty("atualiza_saldo_cc_desc_fin")]
    public string atualizasaldoccdescfin { get; set; }

    [JsonProperty("agrega_valor_desc_fin")]
    public string agregavalordescfin { get; set; }

    [JsonProperty("origem_preco")]
    public string origempreco { get; set; }

    [JsonProperty("repasse")]
    public string repasse { get; set; }

    [JsonProperty("utiliza_calculos_tmt")]
    public string utilizacalculostmt { get; set; }

    [JsonProperty("tv10_usa_custo_produto")]
    public string tv10usacustoproduto { get; set; }

    [JsonProperty("validar_lim_bonific")]
    public string validarlimbonific { get; set; }

    [JsonProperty("categoria_fidelidade_cliente")]
    public string categoriafidelidadecliente { get; set; }

    [JsonProperty("categoria_conexao_cliente")]
    public string categoriaconexaocliente { get; set; }

    [JsonProperty("qtd_passageiro_conexao")]
    public string qtdpassageiroconexao { get; set; }

    [JsonProperty("data_ultima_compra_rca_cliente")]
    public DateTime dataultimacomprarcacliente { get; set; }

    [JsonProperty("codigo_grupo_cliente")]
    public long codigogrupocliente { get; set; }

    [JsonProperty("percentual_tabela_especial")]
    public decimal percentualtabelaespecial { get; set; }

    [JsonProperty("tipo_preco_transferencia")]
    public string tipoprecotransferencia { get; set; }

    [JsonProperty("usa_tabela_especial")]
    public string usatabelaespecial { get; set; }

    [JsonProperty("permite_selecao_validade")]
    public string permiteselecaovalidade { get; set; }


}

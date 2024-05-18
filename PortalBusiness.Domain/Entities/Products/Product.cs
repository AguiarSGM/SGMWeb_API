using Newtonsoft.Json;

namespace PortalBusiness.Domain.Entities.Products;

public class Product
{
    [JsonProperty("codigo_produto")]
    public double Codigoproduto { get; set; }

    [JsonProperty("codigo_produto_principal")]
    public double Codigoprodutoprincipal { get; set; }

    [JsonProperty("descricao_produto")]
    public string Descricaoproduto { get; set; }

    [JsonProperty("embalagem_produto")]
    public string Embalagemproduto { get; set; }

    [JsonProperty("unidade_venda")]
    public string Unidadevenda { get; set; }

    [JsonProperty("peso_embalagem_venda")]
    public double Pesoembalagemvenda { get; set; }

    [JsonProperty("codigo_departamento")]
    public double Codigodepartamento { get; set; }

    [JsonProperty("codigo_secao")]
    public double Codigosecao { get; set; }

    [JsonProperty("codigo_categoria")]
    public double Codigocategoria { get; set; }

    [JsonProperty("codigo_subcategoria")]
    public double Codigosubcategoria { get; set; }

    [JsonProperty("codigo_marca")]
    public double Codigomarca { get; set; }

    [JsonProperty("qt_embalagem_venda")]
    public double Qtembalagemvenda { get; set; }

    [JsonProperty("embalagem_compra")]
    public string Embalagemcompra { get; set; }

    [JsonProperty("unidade_compra")]
    public string Unidadecompra { get; set; }

    [JsonProperty("qt_embalagem_compra")]
    public double Qtdembalagemcompra { get; set; }

    [JsonProperty("codigo_fornecedor")]
    public double Codigofornecedor { get; set; }

    [JsonProperty("data_cadastro")]
    public DateTime Datacadastro { get; set; }

    [JsonProperty("codigo_ean")]
    public double Codigoean { get; set; }

    [JsonProperty("codigo_dun")]
    public double Codigodun { get; set; }

    [JsonProperty("referencia")]
    public string Referencia { get; set; }

    [JsonProperty("codigo_distribuicao")]
    public string Codigodistribuicao { get; set; }

    [JsonProperty("comissao_vendedor_interno")]
    public double Comissaovendedorinterno { get; set; }

    [JsonProperty("comissao_representante")]
    public double Comissaorepresentante { get; set; }

    [JsonProperty("comissao_vendedor_externo")]
    public double Comissaovendedorexterno { get; set; }

    [JsonProperty("informacoes_tecnicas")]
    public string Informacoestecnicas { get; set; }

    [JsonProperty("caminho_foto_produto")]
    public string Caminhofotoproduto { get; set; }

    [JsonProperty("aceita_venda_fracao")]
    public string Aceitavendafracao { get; set; }

    [JsonProperty("peso_variavel")]
    public string Pesovariavel { get; set; }

    [JsonProperty("ncm_produto")]
    public string Ncmproduto { get; set; }

    [JsonProperty("tipo_estoque_produto")]
    public string Tipoestoqueproduto { get; set; }

    [JsonProperty("tipo_estoque")]
    public string Tipoestoque { get; set; }

    [JsonProperty("aceita_venda_fracionada")]
    public string Aceitavendafracionada { get; set; }

    [JsonProperty("checa_multiplo_venda_bnf")]
    public string Checamultiplovendabnf { get; set; }

    [JsonProperty("multiplo_produto")]
    public double Multiploproduto { get; set; }

    [JsonProperty("qt_minima_preco_atacado")]
    public double Qtdminimaprecoatacado { get; set; }

    [JsonProperty("estoque_disponivel")]
    public double Estoquedisponivel { get; set; }

    [JsonProperty("dados_comerciais")]
    public string Dados_comerciais { get; set; }
}

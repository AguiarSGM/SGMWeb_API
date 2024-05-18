using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PortalBusiness.Domain.Entities.Products;

public class ProductsResumeOut
{
    [JsonProperty("codigo_produto")]
    public double CodigoProduto { get; set; }

    [JsonProperty("descricao_produto")]
    public string DescricaoProduto { get; set; }

    [JsonProperty("marca_produto")]
    public string Marca { get; set; }

    [JsonProperty("embalagem_produto")]
    public string EmbalagemProduto { get; set; }

    [JsonProperty("unidade_venda")]
    public string UnidadeVenda { get; set; }

    [JsonProperty("estoque_disponivel")]
    public double EstoqueDisponivel { get; set; }

    private string _dados_comerciais;

    [JsonIgnore]
    public string dados_comerciais
    {
        get => _dados_comerciais;
        set
        {
            _dados_comerciais = value.Replace("\r\n", "");
            Dados_Comerciais = JObject.Parse(_dados_comerciais);
        }
    }

    [JsonProperty("dados_comerciais")]
    public JObject Dados_Comerciais { get; private set; }

    [JsonProperty("mix_cliente")]
    public string MixCliente { get; set; }

    [JsonProperty("codigo_departamento")]
    public string CodigoDepartamento { get; set; }

    [JsonProperty("codigo_secao")]
    public string CodigoSecao { get; set; }

    [JsonProperty("codigo_categoria")]
    public string CodigoCategoria { get; set; }

    [JsonProperty("codigo_subcategoria")]
    public string CodigoSubcategoria { get; set; }

    [JsonProperty("codigo_marca")]
    public string CodigoMarca { get; set; }

    [JsonProperty("codigo_fornecedor")]
    public string CodigoFornecedor { get; set; }

    [JsonProperty("possui_campanha_shelf")]
    public string PossuiCampanhaShelf { get; set; }

    [JsonProperty("quantidade_embalagem_venda")]
    public double QtEmbalagemVenda { get; set; }
    public string ImgProduto { get; set; }
}

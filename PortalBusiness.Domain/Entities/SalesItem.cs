using Newtonsoft.Json;

namespace PortalBusiness.Domain.Entities;

public class SalesItem
{
    [JsonProperty("id_user")]
    public long IDUSUARIO { get; set; }

    [JsonProperty("rca_order_id")]
    public double CODIGOPEDIDORCA { get; set; }

    [JsonProperty("item")]
    public long ITEM { get; set; }

    [JsonProperty("product_code")]
    public long CODIGOPRODUTO { get; set; }

    [JsonProperty("product_description")]
    public string DESCRICAOPRODUTO { get; set; }

    [JsonProperty("unit_sales")]
    public string UNIDADEVENDA { get; set; }

    [JsonProperty("quantity")]
    public double QUANTIDADE { get; set; }

    [JsonProperty("quantity_met")]
    public double QUANTIDADEATENDIDA { get; set; }

    [JsonProperty("quantity_cut")]
    public double QTDCORTE { get; set; }

    [JsonProperty("discount_sale_price")]
    public double PRECOVENDADESCONTO { get; set; }
}

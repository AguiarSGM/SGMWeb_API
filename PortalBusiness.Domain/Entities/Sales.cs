using Newtonsoft.Json;

namespace PortalBusiness.Domain.Entities;

public class Sales
{
    [JsonProperty("date")]
    public DateTime datapedido { get; set; }

    [JsonProperty("subsidiary")]

    public string filial { get; set; }

    [JsonProperty("id_user")]

    public long idusuario { get; set; }

    [JsonProperty("rca_order_id")]

    public string codigopedidorca { get; set; }

    [JsonProperty("client_code")]

    public int codigocliente { get; set; }

    [JsonProperty("business_name")]

    public string razaosocialcliente { get; set; }

    [JsonProperty("fantasy_name")]

    public string fantasiacliente { get; set; }

    [JsonProperty("type_sale")]

    public string tipovenda { get; set; }

    [JsonProperty("description_type_sale")]

    public string descricaotipovenda { get; set; }

    [JsonProperty("status")]

    public string status { get; set; }

    [JsonProperty("billing_code_order")]

    public string codigocobrancapedido { get; set; }

    [JsonProperty("payment_plan_code_order")]

    public string codigoplanopagamentopedido { get; set; }

    [JsonProperty("payment_situation_erp")]

    public string situacaopedidoerp { get; set; }

    [JsonProperty("order_number_erp")]

    public long numeropedidoerp { get; set; }

    [JsonProperty("total_order_amount")]

    public double valortotalpedido { get; set; }

    [JsonProperty("date_delivery")]
    public DateTime dataentregapedido { get; set; }
}

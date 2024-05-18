using Newtonsoft.Json;

namespace PortalBusiness.Domain.Entities.SalesClass;

public class SalesOut
{
    [JsonProperty("date")]
    public DateTime Date { get; init; }

    [JsonProperty("subsidiary")]
    public string Subsidiary { get; init; }

    [JsonProperty("id_user")]
    public long IDUser { get; init; }

    [JsonProperty("rca_order_id")]
    public double RCAOrderID { get; init; }

    [JsonProperty("client_code")]
    public double ClientCode { get; init; }

    [JsonProperty("business_name")]
    public string BusinessName { get; init; }

    [JsonProperty("fantasy_name")]
    public string FantasyName { get; init; }

    [JsonProperty("type_sale")]
    public string TypeSale { get; init; }

    [JsonProperty("description_type_sale")]
    public string DescriptionTypeSale { get; init; }

    [JsonProperty("status")]
    public string Status { get; init; }

    [JsonProperty("billing_code_order")]
    public string BillingCodeOrder { get; init; }

    [JsonProperty("payment_plan_code_order")]
    public string PaymentPlanCodeOrder { get; init; }

    [JsonProperty("payment_situation_erp")]
    public string PaymentSituationERP { get; init; }

    [JsonProperty("order_number_erp")]
    public double OrderNumberERP { get; init; }

    [JsonProperty("total_order_amount")]
    public double TotalOrderAmount { get; init; }

    [JsonProperty("observation_return")]
    public string ObservacaoRetorno { get; init; }

    [JsonProperty("origin_order")]
    public string OrigemPedido { get; init; }

    [JsonProperty("date_delivery")]
    public DateTime DateDelivery { get; init; }
}

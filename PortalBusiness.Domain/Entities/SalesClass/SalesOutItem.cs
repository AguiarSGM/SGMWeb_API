namespace PortalBusiness.Domain.Entities.SalesClass;

using Newtonsoft.Json;

public class SalesOutItem
{
    [JsonProperty("id_user")]
    public long IDUser { get; set; }

    [JsonProperty("rca_order_id")]
    public double RCAOrderID { get; set; }

    [JsonProperty("item")]
    public long Item { get; set; }

    [JsonProperty("product_code")]
    public long ProductCode { get; set; }

    [JsonProperty("product_description")]
    public string ProductDescription { get; set; }

    [JsonProperty("unit_sales")]
    public string UnitSales { get; set; }

    [JsonProperty("quantity")]
    public double Quantity { get; set; }

    [JsonProperty("quantity_met")]
    public double QuantityMet { get; set; }

    [JsonProperty("quantity_cut")]
    public double QuantityCut { get; set; }

    [JsonProperty("discount_sale_price")]
    public double DiscountSalePrice { get; set; }
}


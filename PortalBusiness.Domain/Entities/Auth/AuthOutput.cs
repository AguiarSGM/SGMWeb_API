using Newtonsoft.Json;
using System;

namespace PortalBusiness.Domain.Entities.Auth;

public class AuthOutput
{
    [JsonProperty("id")]
    public long ID { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("login")]
    public string Login { get; set; }

    [JsonIgnore]
    public string Password { get; set; }

    [JsonProperty("rca_code")]
    public string UserCode { get; set; }

    [JsonProperty("supervisor_id")]
    public long SuperID { get; set; }

    [JsonProperty("user_situation")]
    public string UserSituation { get; set; }

    [JsonProperty("profile_id")]
    public long ProfileID { get; set; }

    [JsonProperty("profile_name")]
    public string ProfileName { get; set; }

    [JsonProperty("profile_tag")]
    public string ProfileTag { get; set; }

    [JsonProperty("token")]
    public string Token { get; set; }

    [JsonProperty("codRCA")]
    public int codRCA { get; set; }

    public DateTime Expiration { get; set; }
    public string PermiteCriarObjetivo { get; set; }
}

using Newtonsoft.Json;

namespace PortalBusiness.Domain.Entities.Auth;

public class AuthInput
{
    [JsonProperty("user")]
    public string User { get; set; }

    [JsonProperty("password")]
    public string Password { get; set; }

    public void Validate()
    {
        if (string.IsNullOrEmpty(User))
        {
            throw new ArgumentException("Email inválido");
        }

        if (string.IsNullOrEmpty(Password))
        {
            throw new ArgumentException("Senha inválida");
        }
    }
}

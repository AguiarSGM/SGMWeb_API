using Newtonsoft.Json;

namespace PortalBusiness.Domain.Entities;

public class Department
{
    [JsonProperty("codigo_departamento")]
    public int codigodepartamento { get; set; }

    [JsonProperty("descricao_departamento")]
    public string descricaodepartamento { get; set; }
}

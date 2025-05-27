namespace JohnChum.SharedKernel.SpecificationQuery.LHS.ApiWrapper;

[Serializable]
public class ApiBaseResponse
{
    public int StatusCode { get; set; }

    public string? Message { get; set; }
}
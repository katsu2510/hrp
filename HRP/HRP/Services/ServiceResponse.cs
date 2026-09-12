namespace HRP;

public class ValidationError
{
    public string? PropertyName {get;init;}
    public string Message{get;init;}

    public ValidationError(string? propertyName, string message)
    {
        PropertyName=propertyName;
        Message=message;
    }
}

public class ServiceResponse
{
    public bool Success{ get; init; }
    public List<ValidationError> Errors{get;init;}=new();

    public ServiceResponse(bool success, List<ValidationError> errors)
    {
        Success=success;
        Errors=errors;
    }

}
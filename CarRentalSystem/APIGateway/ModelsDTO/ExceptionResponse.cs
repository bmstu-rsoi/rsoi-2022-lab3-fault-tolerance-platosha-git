namespace APIGateway.ModelsDTO;

public class ExceptionResponse
{
    public ExceptionResponse(string message)
    {
        Message = message;
    }
    
    public string Message { get; set; }
}
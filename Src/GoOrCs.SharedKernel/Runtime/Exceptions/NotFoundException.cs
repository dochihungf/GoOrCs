namespace GoOrCs.SharedKernel.Runtime.Exceptions;

public class NotFoundException : Exception
{
    public string Type { get; set; } = "NOT_FOUND";
    
    public NotFoundException() { }

    public NotFoundException(string? message) : base(message)
    {
        
    }

    public NotFoundException(string? message, Exception? innerException) : base(message, innerException) { }
}

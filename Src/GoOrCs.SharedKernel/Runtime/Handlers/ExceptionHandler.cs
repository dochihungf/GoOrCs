namespace GoOrCs.SharedKernel.Runtime.Handlers;

public class ExceptionHandler : IExceptionHandler
{
    public Task PutToDatabaseAsync(Exception ex)
    {
        throw new NotImplementedException();
    }
}
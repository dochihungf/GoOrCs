namespace GoOrCs.SharedKernel.Runtime.Handlers;

public interface IExceptionHandler
{
    Task PutToDatabaseAsync(Exception ex);
}
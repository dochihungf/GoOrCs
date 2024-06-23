using GoOrCs.SharedKernel.Mailing.Models;

namespace GoOrCs.SharedKernel.Mailing.Abstractions;

public interface IMailService
{
    void SendMail(Mail mail);
    Task SendEmailAsync(Mail mail);
}

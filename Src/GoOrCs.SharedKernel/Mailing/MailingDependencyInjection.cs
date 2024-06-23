using GoOrCs.SharedKernel.Mailing.Abstractions;
using GoOrCs.SharedKernel.Mailing.MailKit;
using GoOrCs.SharedKernel.Mailing.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GoOrCs.SharedKernel.Mailing;

public static class MailingDependencyInjection
{
    public static IServiceCollection AddMailing(this IServiceCollection services, IConfiguration configuration)
    {
        ArgumentNullException.ThrowIfNull(services);
        ArgumentNullException.ThrowIfNull(configuration);

        // Options support
        services.Configure<MailSettings>(configuration.GetSection(nameof(MailSettings)));

        services.AddSingleton<IMailService, MailKitMailService>();

        return services;
    }
}
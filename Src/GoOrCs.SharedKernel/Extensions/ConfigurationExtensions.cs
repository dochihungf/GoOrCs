using Microsoft.Extensions.Configuration;

namespace GoOrCs.SharedKernel.Extensions;

public static class ConfigurationExtensions
{
    public static T GetOptions<T>(this IConfiguration configuration, string section) where T : class, new()
    {
        var options = new T();
        configuration.GetSection(section).Bind(options);

        return options;
    }

    public static T GetOptions<T>(this IConfiguration configuration) where T : class, new()
    {
        return GetOptions<T>(configuration, typeof(T).Name);
    }
}
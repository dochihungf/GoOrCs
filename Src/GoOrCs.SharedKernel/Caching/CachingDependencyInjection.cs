using GoOrCs.SharedKernel.Caching.Distributed;
using GoOrCs.SharedKernel.Caching.Settings;
using GoOrCs.SharedKernel.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using StackExchange.Redis;

namespace GoOrCs.SharedKernel.Caching;

public static class CachingDependencyInjection
{
    public static IServiceCollection AddDistributedRedisCaching(this IServiceCollection services, IConfiguration configuration)
    {
        var configSection = configuration.GetSection(nameof(DistributedCacheSettings));
        services.Configure<DistributedCacheSettings>(configSection);
        
        var asyncPolicy = PollyExtensions.CreateDefaultPolicy(cfg =>
        {
            cfg.Or<RedisServerException>()
                .Or<RedisConnectionException>();
        });
        
        services.AddSingleton<IDistributedRedisCache>(s => new DistributedRedisCache(
            s.GetRequiredService<IOptions<DistributedCacheSettings>>(),
            asyncPolicy));

        return services;
    }
}
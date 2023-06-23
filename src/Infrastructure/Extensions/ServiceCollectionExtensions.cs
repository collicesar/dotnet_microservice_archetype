
using Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IUserProfileRepository, MockUserProfileRespository>();
        services.AddScoped<IUserPreferenceRepository, NpgUserPreferenceRepository>();        
    }
}
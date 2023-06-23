
using Microsoft.AspNetCore.Mvc;

public class PreferencesModule : IModule
{
    public IServiceCollection RegisterModule(IServiceCollection services)
    {
        return services;
    }

    public IEndpointRouteBuilder MapEndpoints(IEndpointRouteBuilder endpoints)
    {
        endpoints.MapGet("/preferences", 
            async([FromServices] IUserPreferenceRepository repository) 
                => await GetUserPreferences.Handler("1e489a21-a110-4131-8a68-ef7bacfca9c9", repository))
            .CacheOutput()
            .WithTags("Preferences")
            .WithName("Preferences");

        return endpoints;
    }

}
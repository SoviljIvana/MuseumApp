using Microsoft.Extensions.DependencyInjection;


namespace OpenSourceSoftwareDevelopment.Museum.API.ServiceExtensions
{
    public static class ServiceCollectionExtensions
    {

        public static void AddOpenApi(this IServiceCollection services)
        {
            services.AddOpenApiDocument();
        }
    }
}



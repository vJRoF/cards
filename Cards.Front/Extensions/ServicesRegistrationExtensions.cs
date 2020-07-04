using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Cards.Front.Extensions
{
    static class ServicesRegistrationExtensions
    {
        /// <summary>
        ///     Register the Swagger generator, defining 1 or more Swagger documents
        /// </summary>
        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            return services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "API метафорических карт", Version = "v1" });
                options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
                {
                    Description = "Standard Authorization header using the Bearer scheme. Example: \"bearer {token}\"",
                    In = ParameterLocation.Header,
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });
            });
        }
    }
}

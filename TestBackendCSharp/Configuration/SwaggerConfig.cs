using Microsoft.OpenApi.Models;

namespace TestBackendCSharp.Api.Configuration
{
    public static class SwaggerConfig
    {
        public static IServiceCollection ConfigurarSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Transformadores API"
                    });
            });

            return services;
        }

        public static IApplicationBuilder UseSwaggerConfig(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Transformadores API");
            });

            return app;
        }
    }

}

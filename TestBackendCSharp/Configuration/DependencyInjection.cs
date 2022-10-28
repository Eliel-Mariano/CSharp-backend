using TestCSharp.Application.Interfaces;
using TestCSharp.Application.Services;
using TestCSharp.Database;

namespace TestCSharp.Api.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection ResolveDependency(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<UserService, UserService>();

            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            return services;
        }
    }
}


﻿using TestBackendCSharp.Database;
using TestCSharp.Application.Interfaces;
using TestCSharp.Application.Services;
using TestCSharp.Business.Business;
﻿using TestCSharp.Application.Interfaces;
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


            services.AddScoped<ITransformatorRepository, TransformatorRepository>();
            services.AddScoped<TransformatorService, TransformatorService>();

            services.AddScoped<ITestRepository, TestRepository>();
            services.AddScoped<TestService, TestService>();

            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            return services;
        }
    }
}

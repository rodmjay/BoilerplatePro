#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using BoilerplatePro.Base.Common.Data.Contexts;
using BoilerplatePro.Base.Common.Middleware.Extensions;
using BoilerplatePro.Base.Common.Settings;
using BoilerplatePro.Base.Currencies.Extensions;
using BoilerplatePro.Base.Geography.Extensions;
using BoilerplatePro.Base.Languages.Extensions;
using BoilerplatePro.Base.Timezones.Extensions;
using BoilerplatePro.Base.Users.Extensions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace BoilerplatePro.Api;

public class Startup
{
    private readonly HttpMessageHandler _identityServerMessageHandler;

    public Startup(IConfiguration configuration, IWebHostEnvironment environment,
        HttpMessageHandler identityServerMessageHandler = null)
    {
        _identityServerMessageHandler = identityServerMessageHandler;
        Configuration = configuration;
        Environment = environment;
    }

    public IWebHostEnvironment Environment { get; }
    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        var builder = services.ConfigureApp(Configuration, Environment)
            .AddDatabase<ApplicationContext>()
            .AddAutoMapperProfilesFromAssemblies()
            .AddCaching()
            .AddUserAccessor()
            .AddUserDependencies()
            .AddGeographyDependencies()
            .AddCurrencyDependencies()
            .AddTimezoneDependencies()
            .AddLanguageDependencies();

        var webAppBuilder = builder.ConfigureWebApp(Environment);

        var restBuilder = webAppBuilder.ConfigureRest()
            .AddAuthorization(policy =>
            {
                policy.RequireAuthenticatedUser();
                policy.RequireClaim("scope", builder.AppSettings.Audience);
                policy.RequireClaim("scope", "openid");
                policy.RequireClaim("scope", "profile");
            })
            .AddBearerAuthentication(options =>
            {
                options.RequireHttpsMetadata = false;
                options.Authority = builder.AppSettings.Authority;
                options.Audience = builder.AppSettings.Audience;

                if (_identityServerMessageHandler != null)
                    options.BackchannelHttpHandler = _identityServerMessageHandler;

                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateAudience = false,
                    ValidAudience = builder.AppSettings.Audience,

                    NameClaimType = "name",
                    RoleClaimType = "role"
                };

                options.Events = new JwtBearerEvents
                {
                    OnAuthenticationFailed = c =>
                    {
                        var logger = c.HttpContext.RequestServices.GetRequiredService<ILogger<StartupBase>>();
                        logger.LogTrace("Authentication Failure");
                        return Task.FromResult(0);
                    },
                    OnTokenValidated = c =>
                    {
                        var logger = c.HttpContext.RequestServices.GetRequiredService<ILogger<StartupBase>>();
                        logger.LogTrace("Authentication Success");
                        return Task.FromResult(0);
                    }
                };
            })
            .AddSwagger(Assembly.GetAssembly(GetType()))
            .AddCors(builder.AppSettings.JsClientUrl,
                builder.AppSettings.Authority,
                builder.AppSettings.MvcClientUrl);
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ApplicationContext context,
        IOptions<AppSettings> settings)
    {
        RestApiBuilderExtensions.Configure(app, env, context, settings);
    }
}
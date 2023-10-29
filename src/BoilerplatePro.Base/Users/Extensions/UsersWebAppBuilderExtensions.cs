﻿#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System;
using BoilerplatePro.Base.Common.Middleware.Builders;
using BoilerplatePro.Base.Users.Interfaces;
using BoilerplatePro.Base.Users.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace BoilerplatePro.Base.Users.Extensions
{
    public static class UsersWebAppBuilderExtensions
    {
        public static WebAppBuilder AddSession(this WebAppBuilder builder)
        {
            builder.Services.AddSession(options =>
            {
                //options.IdleTimeout = TimeSpan.FromSeconds(1000);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });
            return builder;
        }

        public static WebAppBuilder AddUserAccessor(this WebAppBuilder builder)
        {
            builder.Services.TryAddScoped<IUserAccessor, UserAccessor>();
            builder.Services.TryAddScoped(x =>
            {
                var httpContextAccessor = x.GetRequiredService<IHttpContextAccessor>();
                var userAccessor = x.GetRequiredService<IUserAccessor>();

                return userAccessor.GetUser(httpContextAccessor.HttpContext.User).Result;
            });

            return builder;
        }

        public static WebAppBuilder AddAuthorization(this WebAppBuilder builder,
            Action<AuthorizationPolicyBuilder> action)
        {
            builder.Services.AddAuthorization(options => { options.AddPolicy("ApiScope", action); });

            return builder;
        }
    }
}
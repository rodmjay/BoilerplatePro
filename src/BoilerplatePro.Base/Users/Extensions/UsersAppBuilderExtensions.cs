﻿#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System;
using BoilerplatePro.Base.Common.Data.Contexts;
using BoilerplatePro.Base.Common.Middleware.Builders;
using BoilerplatePro.Base.Users.Entities;
using BoilerplatePro.Base.Users.Factories;
using BoilerplatePro.Base.Users.Interfaces;
using BoilerplatePro.Base.Users.Managers;
using BoilerplatePro.Base.Users.Services;
using BoilerplatePro.Base.Users.Validators;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace BoilerplatePro.Base.Users.Extensions
{
    public static class UsersAppBuilderExtensions
    {
        public static AppBuilder AddUserAccessor(this AppBuilder builder)
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
        public static AppBuilder AddIdentity(this AppBuilder builder)
        {
            builder.Services.AddIdentityCore<User>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = true;

                    // password requirements
                    options.Password.RequireDigit = false;
                    options.Password.RequireLowercase = true;
                    options.Password.RequireNonAlphanumeric = true;
                    options.Password.RequireUppercase = true;

                    options.ClaimsIdentity.EmailClaimType = "email";
                    options.ClaimsIdentity.RoleClaimType = "role";
                    options.ClaimsIdentity.UserIdClaimType = "sub";
                    options.ClaimsIdentity.UserNameClaimType = "name";
                    options.ClaimsIdentity.SecurityStampClaimType = "ss";

                    options.Lockout.MaxFailedAccessAttempts = 5;
                    options.Lockout.AllowedForNewUsers = true;
                    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromDays(1);

                    options.Stores.ProtectPersonalData = false;

                    options.User.RequireUniqueEmail = true;
                })
                .AddRoles<Role>()
                .AddRoleStore<RoleService>()
                .AddUserStore<UserService>()
                .AddEntityFrameworkStores<ApplicationContext>()
                .AddDefaultTokenProviders()
                .AddDefaultUI()
                .AddClaimsPrincipalFactory<UserRoleClaimsPrincipalFactory>()
                .AddRoleManager<RoleManager>()
                .AddUserManager<UserManager>()
                .AddSignInManager<SignInManager>();

            builder.Services.Configure<DataProtectionTokenProviderOptions>(opt =>
                opt.TokenLifespan = TimeSpan.FromHours(24));


            return builder;
        }

        public static AppBuilder AddUserDependencies(this AppBuilder builder)
        {
            builder.Services.TryAddScoped<IUserService, UserService>();
            builder.Services.TryAddScoped<IRoleService, RoleService>();

            builder.Services.TryAddScoped<IUserClaimsPrincipalFactory<User>, UserRoleClaimsPrincipalFactory>();
            builder.Services.TryAddScoped<UserRoleClaimsPrincipalFactory>();

            builder.Services.TryAddTransient<IPasswordHasher<User>, PasswordHasher<User>>();
            builder.Services.TryAddScoped<IUserConfirmation<User>, DefaultUserConfirmation<User>>();
            builder.Services.TryAddScoped<ILookupNormalizer, UpperInvariantLookupNormalizer>();

            builder.Services.TryAddScoped<IdentityErrorDescriber>();

            builder.Services.TryAddScoped<UserManager<User>, UserManager>();
            builder.Services.TryAddScoped<UserManager>();

            builder.Services.TryAddScoped<RoleManager<Role>, RoleManager>();
            builder.Services.TryAddScoped<RoleManager>();

            builder.Services.TryAddTransient<IUserValidator<User>, DuplicateEmailValidator>();
            builder.Services.TryAddTransient<IUserValidator<User>, DuplicateUserNameValidator>();

            return builder;
        }

        public static WebAppBuilder AddSigninDependencies(this WebAppBuilder builder)
        {
            builder.Services.AddHttpContextAccessor();

            builder.Services.TryAddScoped<SignInManager<User>, SignInManager>();
            builder.Services.TryAddScoped<SignInManager>();

            return builder;
        }
    }
}
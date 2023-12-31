﻿#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System.Runtime.CompilerServices;
using BoilerplatePro.Base.Common.Middleware.Builders;
using BoilerplatePro.Base.Common.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace BoilerplatePro.Base.Common.Middleware.Extensions
{
    public static class ServiceCollectionExtensions
    {
        private static string GetLogMessage(string message, [CallerMemberName] string callerName = null)
        {
            return $"[{nameof(ServiceCollectionExtensions)}.{callerName}] - {message}";
        }


        public static AppBuilder ConfigureApp(
            this IServiceCollection services, IConfiguration configuration, IHostEnvironment environment)
        {
            var appSettings = new AppSettings();

            var settingsSection = configuration.GetSection("AppSettings");
            settingsSection.Bind(appSettings);

            Log.Logger.Debug(GetLogMessage($"Application: {appSettings.Name}"));

            services.Configure<AppSettings>(settingsSection);
            services.AddOptions();

            return new AppBuilder(services, appSettings, environment, configuration);
        }
    }
}
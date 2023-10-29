#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using BoilerplatePro.Base.Common.Middleware.Builders;
using BoilerplatePro.Base.Geography.Interfaces;
using BoilerplatePro.Base.Geography.Models;
using BoilerplatePro.Base.Geography.Services;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace BoilerplatePro.Base.Geography.Extensions
{
    public static class AppBuilderExtensions
    {
        public static AppBuilder AddGeographyDependencies(this AppBuilder builder)
        {
            builder.Services.TryAddTransient<GeographyErrorDescriber>();
            builder.Services.TryAddScoped<ICountryService, CountryService>();
            builder.Services.TryAddScoped<IEnabledCountryService, EnabledCountryService>();

            return builder;
        }
    }
}
#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using BoilerplatePro.Base.Common.Middleware.Builders;
using BoilerplatePro.Base.Timezones.Interfaces;
using BoilerplatePro.Base.Timezones.Services;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace BoilerplatePro.Base.Timezones.Extensions
{
    public static class AppBuilderExtensions
    {
        public static AppBuilder AddTimezoneDependencies(this AppBuilder builder)
        {
            builder.Services.TryAddScoped<ITimezoneService, TimezoneService>();

            return builder;
        }
    }
}
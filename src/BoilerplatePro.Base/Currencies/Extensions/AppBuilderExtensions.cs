#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using BoilerplatePro.Base.Common.Middleware.Builders;
using BoilerplatePro.Base.Currencies.Interfaces;
using BoilerplatePro.Base.Currencies.Services;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace BoilerplatePro.Base.Currencies.Extensions
{
    public static class AppBuilderExtensions
    {
        public static AppBuilder AddCurrencyDependencies(this AppBuilder builder)
        {
            builder.Services.TryAddScoped<ICurrencyService, CurrencyService>();

            return builder;
        }
    }
}
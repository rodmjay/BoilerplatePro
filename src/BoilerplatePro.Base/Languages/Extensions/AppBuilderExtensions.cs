#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using BoilerplatePro.Base.Common.Middleware.Builders;
using BoilerplatePro.Base.Languages.Interfaces;
using BoilerplatePro.Base.Languages.Services;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace BoilerplatePro.Base.Languages.Extensions
{
    public static class AppBuilderExtensions
    {
        public static AppBuilder AddLanguageDependencies(this AppBuilder builder)
        {
            builder.Services.TryAddScoped<ILanguageService, LanguageService>();

            return builder;
        }
    }
}
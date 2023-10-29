#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using BoilerplatePro.Base.Common.Settings;
using Microsoft.Extensions.DependencyInjection;

namespace BoilerplatePro.Base.Common.Middleware.Builders
{
    public class UIBuilder
    {
        public UIBuilder(WebAppBuilder serviceBuilder)
        {
            Services = serviceBuilder.Services;
            AppSettings = serviceBuilder.AppSettings;
        }

        public AppSettings AppSettings { get; }
        public IServiceCollection Services { get; }
    }
}
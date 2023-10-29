#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using BoilerplatePro.Base.Common.Settings;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BoilerplatePro.Base.Common.Middleware.Builders
{
    public class SpaBuilder
    {
        public SpaBuilder(IServiceCollection services,
            AppSettings settings,
            IConfiguration configuration,
            IWebHostEnvironment environment)
        {
            Services = services;
            AppSettings = settings;
            Configuration = configuration;
            Environment = environment;
        }

        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Environment { get; }
        public IServiceCollection Services { get; }

        public AppSettings AppSettings { get; set; }
    }
}
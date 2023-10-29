#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using BoilerplatePro.Base.Common.Middleware.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BoilerplatePro.Client
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CreateHostBuilder(args).Init();
        }

        private static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(HostBuilderExtensions.Configure)
                .ConfigureServices((hostBuilderContext, services) =>
                {
                    services.ConfigureApp(hostBuilderContext.Configuration, hostBuilderContext.HostingEnvironment);
                    services.AddHostedService<Worker>();
                });
        }
    }
}
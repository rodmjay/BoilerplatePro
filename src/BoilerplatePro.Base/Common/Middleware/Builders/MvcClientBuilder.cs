﻿#region Header

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
    public class MvcClientBuilder
    {
        public MvcClientBuilder(WebAppBuilder builder)
        {
            Services = builder.Services;
            AppSettings = builder.AppSettings;
            Configuration = builder.Configuration;
            Environment = builder.Environment;
        }

        public IConfiguration Configuration { get; }
        public IWebHostEnvironment Environment { get; }
        public AppSettings AppSettings { get; set; }

        public IServiceCollection Services { get; }
    }
}
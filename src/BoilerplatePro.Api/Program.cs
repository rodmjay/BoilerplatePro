#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System.Diagnostics.CodeAnalysis;
using BoilerplatePro.Base.Common.Middleware.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace BoilerplatePro.Api;

[ExcludeFromCodeCoverage]
public class Program
{
    public static void Main(string[] args)
    {
        BuildHost(args)
            .Init();
    }

    public static IHostBuilder BuildHost(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration(HostBuilderExtensions.Configure)
            .ConfigureWebHostDefaults(builder =>
            {
                builder
                    .ConfigureLogging(HostBuilderExtensions.ConfigureLogging)
                    .UseSerilog()
                    .UseStartup<Startup>();
            });
    }
}
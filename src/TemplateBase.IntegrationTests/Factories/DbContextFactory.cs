﻿#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TemplateBase.Common.Data.Contexts;

namespace TemplateBase.IntegrationTests.Factories
{
    [ExcludeFromCodeCoverage]
    public static class DbContextFactory
    {
        public static DbContextOptions<ApplicationContext> CreateContextOptions(IConfiguration configuration)
        {
            var connString = configuration.GetConnectionString("DefaultConnection");
            var opts = new DbContextOptionsBuilder<ApplicationContext>();
            opts.UseSqlServer(connString,
                provider => provider.EnableRetryOnFailure());
            opts.EnableSensitiveDataLogging();

            return opts.Options;
        }
    }
}
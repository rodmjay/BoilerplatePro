﻿#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using Microsoft.Extensions.DependencyInjection;
using TemplateBase.Common.Settings;

namespace TemplateBase.Common.Middleware.Builders
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
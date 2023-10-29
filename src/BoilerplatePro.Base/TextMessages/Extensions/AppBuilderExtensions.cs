#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using BoilerplatePro.Base.Common.Middleware.Builders;
using BoilerplatePro.Base.TextMessages.Services;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Twilio;

namespace BoilerplatePro.Base.TextMessages.Extensions
{
    public static class AppBuilderExtensions
    {
        public static AppBuilder AddTwilio(this AppBuilder builder)
        {
            TwilioClient.Init(builder.AppSettings.Twilio.AccountSid, builder.AppSettings.Twilio.AuthToken);

            builder.Services.TryAddScoped<TwilioSmsService>();

            return builder;
        }
    }
}
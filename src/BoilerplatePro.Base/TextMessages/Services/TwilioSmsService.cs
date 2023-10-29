#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using BoilerplatePro.Base.TextMessages.Settings;
using Microsoft.Extensions.Options;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace BoilerplatePro.Base.TextMessages.Services
{
    public class TwilioSmsService
    {
        private readonly TwilioSettings _settings;

        public TwilioSmsService(IOptions<TwilioSettings> settings)
        {
            _settings = settings.Value;
        }

        public void SendMessage()
        {
            var message = MessageResource.Create(new PhoneNumber(""), from: new PhoneNumber(""));
        }
    }
}
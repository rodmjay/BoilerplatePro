﻿#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System.Threading.Tasks;
using BoilerplatePro.Base.Email.Settings;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace BoilerplatePro.Base.Email.Services
{
    public class SendgridEmailSender : IEmailSender
    {
        private readonly SendGridClient _client;
        private readonly SendGridSettings _settings;

        public SendgridEmailSender(SendGridClient client, IOptions<SendGridSettings> settings)
        {
            _client = client;
            _settings = settings.Value ?? new SendGridSettings();
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var msg = new SendGridMessage
            {
                From = new EmailAddress(_settings.FromEmail, _settings.FromName),
                Subject = subject,
                HtmlContent = htmlMessage
            };
            msg.AddTo(new EmailAddress(email));

            var response = await _client.SendEmailAsync(msg);
        }
    }
}
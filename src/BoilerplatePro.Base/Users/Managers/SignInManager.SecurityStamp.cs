﻿#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System.Security.Claims;
using System.Threading.Tasks;
using BoilerplatePro.Base.Users.Entities;
using Microsoft.Extensions.Logging;

namespace BoilerplatePro.Base.Users.Managers
{
    public partial class SignInManager
    {
        public override async Task<User> ValidateSecurityStampAsync(ClaimsPrincipal principal)
        {
            if (principal == null) return null;

            var user = await UserManager.GetUserAsync(principal);
            if (await ValidateSecurityStampAsync(user,
                principal.FindFirstValue(Options.ClaimsIdentity.SecurityStampClaimType)))
                return user;

            _logger.LogDebug(4, "Failed to validate a security stamp.");
            return null;
        }

        public override async Task<bool> ValidateSecurityStampAsync(User user, string securityStamp)
        {
            return user != null &&
                   // Only validate the security stamp if the store supports it
                   (!UserManager.SupportsUserSecurityStamp ||
                    securityStamp == await UserManager.GetSecurityStampAsync(user));
        }
    }
}
﻿#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System.Threading;
using System.Threading.Tasks;
using BoilerplatePro.Base.Users.Entities;

namespace BoilerplatePro.Base.Users.Services
{
    public partial class UserService
    {
        public Task SetAuthenticatorKeyAsync(User user, string key, CancellationToken cancellationToken)
        {
            return SetTokenAsync(user, InternalLoginProvider, AuthenticatorKeyTokenName, key, cancellationToken);
        }

        public Task<string> GetAuthenticatorKeyAsync(User user, CancellationToken cancellationToken)
        {
            return GetTokenAsync(user, InternalLoginProvider, AuthenticatorKeyTokenName, cancellationToken);
        }
    }
}
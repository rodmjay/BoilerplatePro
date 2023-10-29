#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using BoilerplatePro.Base.Common.Services.Interfaces;
using BoilerplatePro.Base.Users.Entities;
using Microsoft.AspNetCore.Identity;

namespace BoilerplatePro.Base.Users.Interfaces
{
    public interface IUserService : IService<User>,
        IQueryableUserStore<User>,
        IUserPasswordStore<User>,
        IUserRoleStore<User>,
        IUserClaimStore<User>,
        IUserLoginStore<User>,
        IUserLockoutStore<User>,
        IUserPhoneNumberStore<User>,
        IUserEmailStore<User>,
        IUserAuthenticatorKeyStore<User>,
        IUserTwoFactorStore<User>,
        IUserTwoFactorRecoveryCodeStore<User>,
        IUserSecurityStampStore<User>,
        IUserAuthenticationTokenStore<User>
    {
    }
}
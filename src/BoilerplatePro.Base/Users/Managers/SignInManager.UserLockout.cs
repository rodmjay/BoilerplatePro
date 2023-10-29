#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System.Threading.Tasks;
using BoilerplatePro.Base.Users.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;

namespace BoilerplatePro.Base.Users.Managers
{
    public partial class SignInManager
    {
        protected override Task<SignInResult> LockedOut(User user)
        {
            Logger.LogWarning(3, "User is currently locked out.");
            return Task.FromResult(SignInResult.LockedOut);
        }

        protected override async Task<bool> IsLockedOut(User user)
        {
            return UserManager.SupportsUserLockout && await UserManager.IsLockedOutAsync(user);
        }
    }
}
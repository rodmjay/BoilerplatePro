#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System.Threading.Tasks;
using BoilerplatePro.Base.Common;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;

namespace BoilerplatePro.Base.Users.Managers
{
    public partial class SignInManager
    {
        public override async Task SignOutAsync()
        {
            await Context.SignOutAsync(Constants.LocalIdentity.DefaultApplicationScheme);
            await Context.SignOutAsync(Constants.LocalIdentity.DefaultExternalScheme);
            await Context.SignOutAsync(IdentityConstants.TwoFactorUserIdScheme);
        }
    }
}
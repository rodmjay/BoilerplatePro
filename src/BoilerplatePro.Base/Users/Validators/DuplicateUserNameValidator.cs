#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System.Threading.Tasks;
using BoilerplatePro.Base.Users.Entities;
using Microsoft.AspNetCore.Identity;

namespace BoilerplatePro.Base.Users.Validators
{
    public class DuplicateUserNameValidator : IUserValidator<User>
    {
        private readonly IdentityErrorDescriber _errors;

        public DuplicateUserNameValidator(IdentityErrorDescriber errors)
        {
            _errors = errors;
        }

        public async Task<IdentityResult> ValidateAsync(UserManager<User> manager, User user)
        {
            var userByEmail = await manager.FindByEmailAsync(user.NormalizedEmail);
            if (userByEmail != null) return IdentityResult.Failed(_errors.DuplicateEmail(user.Email));
            return IdentityResult.Success;
        }
    }
}
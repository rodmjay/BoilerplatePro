#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using BoilerplatePro.Base.Common.Services.Bases;
using BoilerplatePro.Base.Users.Entities;
using BoilerplatePro.Base.Users.Interfaces;
using BoilerplatePro.Base.Users.Managers;
using BoilerplatePro.Base.Users.Models;
using Microsoft.EntityFrameworkCore;

namespace BoilerplatePro.Base.Users.Services
{
    public class UserAccessor : BaseService<User>, IUserAccessor
    {
        private readonly UserManager _userManager;

        public UserAccessor(
            UserManager userManager,
            IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _userManager = userManager;
        }

        public Task<IUser> GetUser(ClaimsPrincipal principal)
        {
            var id = _userManager.GetUserId(principal);

            var userId = int.Parse(id);

            return _userManager.Users.Where(x => x.Id == userId)
                .ProjectTo<UserDto>(ProjectionMapping)
                .Cast<IUser>()
                .FirstOrDefaultAsync();
        }
    }
}
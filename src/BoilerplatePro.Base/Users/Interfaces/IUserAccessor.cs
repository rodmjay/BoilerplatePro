﻿#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System.Security.Claims;
using System.Threading.Tasks;

namespace BoilerplatePro.Base.Users.Interfaces
{
    public interface IUserAccessor
    {
        Task<IUser> GetUser(ClaimsPrincipal principal);
    }
}
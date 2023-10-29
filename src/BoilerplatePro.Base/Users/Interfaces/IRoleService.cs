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
    public interface IRoleService : IService<Role>,
        IRoleStore<Role>,
        IQueryableRoleStore<Role>,
        IRoleClaimStore<Role>
    {
    }
}
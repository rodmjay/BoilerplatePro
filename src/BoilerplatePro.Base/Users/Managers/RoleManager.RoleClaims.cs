﻿#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using BoilerplatePro.Base.Users.Entities;
using Microsoft.AspNetCore.Identity;

namespace BoilerplatePro.Base.Users.Managers
{
    public partial class RoleManager
    {
        public override async Task<IdentityResult> AddClaimAsync(Role role, Claim claim)
        {
            ThrowIfDisposed();
            if (claim == null)
                throw new ArgumentNullException(nameof(claim));
            if (role == null)
                throw new ArgumentNullException(nameof(role));

            await _roleService.AddClaimAsync(role, claim, CancellationToken);
            return await UpdateRoleAsync(role);
        }

        public override Task<IList<Claim>> GetClaimsAsync(Role role)
        {
            ThrowIfDisposed();
            if (role == null)
                throw new ArgumentNullException(nameof(role));
            return _roleService.GetClaimsAsync(role, CancellationToken);
        }

        public override async Task<IdentityResult> RemoveClaimAsync(Role role, Claim claim)
        {
            ThrowIfDisposed();
            if (role == null)
                throw new ArgumentNullException(nameof(role));

            await _roleService.RemoveClaimAsync(role, claim, CancellationToken);
            return await UpdateRoleAsync(role);
        }
    }
}
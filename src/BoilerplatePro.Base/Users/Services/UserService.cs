﻿#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using BoilerplatePro.Base.Common.Data.Interfaces;
using BoilerplatePro.Base.Common.Services.Bases;
using BoilerplatePro.Base.Users.Entities;
using BoilerplatePro.Base.Users.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BoilerplatePro.Base.Users.Services
{
    public partial class UserService : BaseService<User>, IUserService
    {
        private const string InternalLoginProvider = "[AspNetUserStore]";
        private const string AuthenticatorKeyTokenName = "AuthenticatorKey";
        private const string RecoveryCodeTokenName = "RecoveryCodes";
        private readonly IdentityErrorDescriber _errors;
        private readonly IRepositoryAsync<Role> _roleRepository;
        private readonly IRepositoryAsync<UserClaim> _userClaimsRepository;
        private readonly IRepositoryAsync<UserLogin> _userLoginRepository;
        private readonly IRepositoryAsync<UserRole> _userRoleRepository;

        private readonly IRepositoryAsync<UserToken> _userTokenRepository;
        private bool _disposed;

        public UserService(
            IdentityErrorDescriber errors,
            IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _userTokenRepository = UnitOfWork.RepositoryAsync<UserToken>();
            _roleRepository = UnitOfWork.RepositoryAsync<Role>();
            _userRoleRepository = UnitOfWork.RepositoryAsync<UserRole>();
            _userClaimsRepository = UnitOfWork.RepositoryAsync<UserClaim>();
            _userLoginRepository = UnitOfWork.RepositoryAsync<UserLogin>();

            _errors = errors;
        }


        public void Dispose()
        {
            UnitOfWork.Dispose();
            _disposed = true;
        }

        private Task<User> FindUserAsync(int userId, CancellationToken cancellationToken)
        {
            return Users.SingleOrDefaultAsync(u => u.Id.Equals(userId), cancellationToken);
        }

        private int ConvertIdFromString(string id)
        {
            if (id == null) return default(int);
            return (int) TypeDescriptor.GetConverter(typeof(int)).ConvertFromInvariantString(id);
        }

        protected void ThrowIfDisposed()
        {
            if (_disposed) throw new ObjectDisposedException(GetType().Name);
        }
    }
}
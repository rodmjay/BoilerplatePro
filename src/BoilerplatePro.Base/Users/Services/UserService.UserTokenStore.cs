#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BoilerplatePro.Base.Common.Data.Enums;
using BoilerplatePro.Base.Users.Entities;
using Microsoft.EntityFrameworkCore;

namespace BoilerplatePro.Base.Users.Services
{
    public partial class UserService
    {
        public IQueryable<UserToken> UserTokens => _userTokenRepository.Queryable();

        public async Task SetTokenAsync(User user, string loginProvider, string name, string value,
            CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            if (user == null) throw new ArgumentNullException(nameof(user));

            var token = await FindTokenAsync(user, loginProvider, name, cancellationToken);
            if (token == null)
                await AddUserTokenAsync(CreateUserToken(user, loginProvider, name, value));
            else
                token.Value = value;
        }

        public async Task RemoveTokenAsync(User user, string loginProvider, string name,
            CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            ThrowIfDisposed();

            if (user == null) throw new ArgumentNullException(nameof(user));
            var entry = await FindTokenAsync(user, loginProvider, name, cancellationToken);
            if (entry != null) await RemoveUserTokenAsync(entry);
        }

        public Task<string> GetTokenAsync(User user, string loginProvider, string name,
            CancellationToken cancellationToken)
        {
            return Task.FromResult(user.UserTokens
                .FirstOrDefault(x => x.LoginProvider == loginProvider && x.Name == name)
                ?.Value);
        }

        public Task<UserToken> FindTokenAsync(User user, string loginProvider, string name,
            CancellationToken cancellationToken)
        {
            return UserTokens
                .Where(x => x.UserId == user.Id && x.LoginProvider == loginProvider && x.Name == name)
                .FirstOrDefaultAsync(cancellationToken);
        }

        public Task AddUserTokenAsync(UserToken token)
        {
            token.ObjectState = ObjectState.Added;
            ThrowIfDisposed();

            return _userTokenRepository.InsertAsync(token, true);
        }

        public UserToken CreateUserToken(User user, string loginProvider, string name, string value)
        {
            return new()
            {
                ObjectState = ObjectState.Added,
                UserId = user.Id,
                LoginProvider = loginProvider,
                Name = name,
                Value = value
            };
        }

        private Task RemoveUserTokenAsync(UserToken token)
        {
            token.ObjectState = ObjectState.Deleted;
            return _userTokenRepository.DeleteAsync(token, true);
        }
    }
}
#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System;
using System.Threading.Tasks;
using BoilerplatePro.Base.Common.Settings;
using BoilerplatePro.Base.Users.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace BoilerplatePro.Base.Common.Middleware.Bases
{
    [ApiController]
    [Produces("application/json")]
    [Route("v1.0/[controller]")]
    public class BaseController : ControllerBase
    {
        protected readonly AppSettings AppSettings;
        protected readonly IDistributedCache Cache;
        private readonly IUserAccessor _userAccessor;

        /// <param name="serviceProvider"></param>
        protected BaseController(IServiceProvider serviceProvider)
        {
            _userAccessor = serviceProvider.GetService<IUserAccessor>();
            Cache = serviceProvider.GetRequiredService<IDistributedCache>();
            AppSettings = serviceProvider.GetRequiredService<IOptions<AppSettings>>().Value;
        }

        protected async Task<IUser> GetCurrentUser()
        {
            return await _userAccessor.GetUser(User);
        }
        [ActionContext] public ActionContext ActionContext { get; set; }
    }
}
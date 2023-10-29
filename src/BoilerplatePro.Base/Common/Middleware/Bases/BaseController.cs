#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System;
using BoilerplatePro.Base.Common.Settings;
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

        /// <param name="serviceProvider"></param>
        protected BaseController(IServiceProvider serviceProvider)
        {
            Cache = serviceProvider.GetRequiredService<IDistributedCache>();
            AppSettings = serviceProvider.GetRequiredService<IOptions<AppSettings>>().Value;
        }


        [ActionContext] public ActionContext ActionContext { get; set; }
    }
}
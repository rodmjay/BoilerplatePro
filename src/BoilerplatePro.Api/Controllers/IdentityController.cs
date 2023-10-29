#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System;
using System.Linq;
using BoilerplatePro.Base.Common.Middleware.Bases;
using Microsoft.AspNetCore.Mvc;

namespace BoilerplatePro.Api.Controllers.Api.Controllers
{
    public class IdentityController : BaseController
    {
        protected IdentityController(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult(from c in User.Claims select new { c.Type, c.Value });
        }
    }
}
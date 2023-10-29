#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoilerplatePro.Api.Interfaces;
using BoilerplatePro.Base.Common.Middleware.Bases;
using Microsoft.AspNetCore.Mvc;

namespace BoilerplatePro.Api.Controllers;

public class IdentityController : BaseController, IIdentityController
{
    public IdentityController(IServiceProvider serviceProvider) : base(serviceProvider)
    {
    }

    [HttpGet]
    public Task<Dictionary<string, List<string>>> GetCurrentIdentity()
    {
        var dictionary = User.Claims.GroupBy(x => x.Type).ToDictionary(x => x.Key, x => x.Select(c=>c.Value).ToList());

        return Task.FromResult(dictionary);
    }
}
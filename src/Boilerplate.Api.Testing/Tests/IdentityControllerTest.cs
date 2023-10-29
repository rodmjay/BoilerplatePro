#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System.Collections.Generic;
using System.Threading.Tasks;
using BoilerplatePro.Api.Interfaces;
using NUnit.Framework;

namespace Boilerplate.Api.Testing.Tests;

[TestFixture]
public class IdentityControllerTest : BaseApiTest, IIdentityController
{
    [TestFixture]
    public class TheGetCurrentIdentityMethod : IdentityControllerTest
    {
        [Test]
        public async Task CanGetIdentity()
        {
            var result = await GetCurrentIdentity();
            Assert.IsNotNull(result);

            Assert.IsTrue(result.ContainsKey("http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier"));
        }
    }
    public async Task<Dictionary<string, List<string>>> GetCurrentIdentity()
    { 
        var result = await DoGet<Dictionary<string, List<string>>>("v1.0/identity");
        return result;
    }
}
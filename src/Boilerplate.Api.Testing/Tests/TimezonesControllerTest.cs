#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System.Threading.Tasks;
using BoilerplatePro.Api.Interfaces;
using BoilerplatePro.Base.Common.Helpers;
using BoilerplatePro.Base.Common.Models;
using BoilerplatePro.Base.Languages.Interfaces;
using BoilerplatePro.Base.Timezones.Models;
using Microsoft.AspNetCore.Http;
using NUnit.Framework;

namespace Boilerplate.Api.Testing.Tests;

[TestFixture]
public class TimezonesControllerTest : BaseApiTest, ITimezonesController
{
    [TestFixture]
    public class TheGetTimezonesMethod : TimezonesControllerTest
    {
        [Test]
        public async Task CanGetTimezones()
        {
            var timezones = await GetTimezones(new TimezoneFilters(), new PagingQuery());

            Assert.AreEqual(200, timezones.TotalItems);
        }
    }
    public Task<PagedList<TimezoneOutput>> GetTimezones(TimezoneFilters filters, PagingQuery paging)
    {
        var querystring = UrlHelper.CombineObjectsToUrl(filters, paging);
        return DoGetAnonymous<PagedList<TimezoneOutput>>($"/v1.0/timezones?{querystring}");
    }
}
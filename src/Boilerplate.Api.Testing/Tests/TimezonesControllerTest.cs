#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System.Threading.Tasks;
using BoilerplatePro.Api.Interfaces;
using BoilerplatePro.Base.Common.Models;
using BoilerplatePro.Base.Languages.Interfaces;
using BoilerplatePro.Base.Timezones.Models;
using Microsoft.AspNetCore.Http;
using NUnit.Framework;

namespace Boilerplate.Api.Testing.Tests;

[TestFixture]
public class TimezonesControllerTest : BaseApiTest, ITimezonesController
{
    public Task<PagedList<TimezoneOutput>> GetTimezones(TimezoneFilters filters, PagingQuery paging)
    {
        throw new System.NotImplementedException();
    }
}
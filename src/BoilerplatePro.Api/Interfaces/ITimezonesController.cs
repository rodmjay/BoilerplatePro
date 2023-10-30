#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System.Threading.Tasks;
using BoilerplatePro.Base.Common.Models;
using BoilerplatePro.Base.Timezones.Models;
using Microsoft.AspNetCore.Mvc;

namespace BoilerplatePro.Api.Interfaces;

public interface ITimezonesController
{
    Task<PagedList<TimezoneOutput>> GetTimezones([FromQuery] TimezoneFilters filters,
        [FromQuery] PagingQuery paging);
}
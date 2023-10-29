#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System.Threading.Tasks;
using BoilerplatePro.Base.Common.Models;
using BoilerplatePro.Base.Common.Services.Interfaces;
using BoilerplatePro.Base.Timezones.Entities;
using BoilerplatePro.Base.Timezones.Models;

namespace BoilerplatePro.Base.Timezones.Interfaces;

public interface ITimezoneService : IService<Timezone>
{
    Task<PagedList<T>> GetTimezones<T>(TimezoneFilters filters, PagingQuery paging) where T : TimezoneOutput;
}
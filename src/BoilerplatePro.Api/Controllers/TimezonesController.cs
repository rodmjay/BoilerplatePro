using System;
using System.Threading.Tasks;
using BoilerplatePro.Api.Interfaces;
using BoilerplatePro.Base.Common.Middleware.Bases;
using BoilerplatePro.Base.Common.Models;
using BoilerplatePro.Base.Timezones.Interfaces;
using BoilerplatePro.Base.Timezones.Models;
using Microsoft.AspNetCore.Mvc;

namespace BoilerplatePro.Api.Controllers;

public class TimezonesController : BaseController, ITimezonesController
{
    private readonly ITimezoneService _timezoneService;

    public TimezonesController(IServiceProvider serviceProvider, ITimezoneService timezoneService) : base(serviceProvider)
    {
        _timezoneService = timezoneService;
    }

    [HttpGet]
    public async Task<PagedList<TimezoneOutput>> GetTimezones([FromQuery] TimezoneFilters filters,
        [FromQuery] PagingQuery paging)
    {
        return await _timezoneService.GetTimezones<TimezoneOutput>(filters, paging);
    }
}
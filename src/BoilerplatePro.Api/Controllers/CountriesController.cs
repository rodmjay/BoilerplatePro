#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System;
using System.Threading.Tasks;
using BoilerplatePro.Base.Common.Middleware.Bases;
using BoilerplatePro.Base.Common.Models;
using BoilerplatePro.Base.Geography.Extensions;
using BoilerplatePro.Base.Geography.Interfaces;
using BoilerplatePro.Base.Geography.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BoilerplatePro.Api.Controllers.Api.Controllers
{
    public class CountriesController : BaseController
    {
        private readonly ICountryStore _countryService;
        private readonly IEnabledCountryService _enabledCountryService;

        public CountriesController(
            ICountryService countryService,
            IEnabledCountryService enabledCountryService,
            IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _countryService = countryService;
            _enabledCountryService = enabledCountryService;
        }

        [HttpGet]
        [AllowAnonymous]
        public Task<PagedList<CountryDto>> GetCountries([FromQuery] CountryQuery query, [FromQuery] PagingQuery paging)
        {
            return _countryService.GetCountries<CountryDto>(query.GetExpression(), paging);
        }

        [HttpGet("{iso2}")]
        [AllowAnonymous]
        public Task<CountryWithStateProvinces> GetCountry([FromRoute] string iso2)
        {
            return _countryService.GetCountry<CountryWithStateProvinces>(iso2);
        }

        [HttpPatch("{iso2}/enable")]
        public Task<Result> EnableCountry([FromRoute] string iso2)
        {
            return _enabledCountryService.EnableCountry(iso2);
        }
    }
}
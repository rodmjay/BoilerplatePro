﻿#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System.Threading.Tasks;
using BoilerplatePro.Base.Common.Models;
using BoilerplatePro.Base.Geography.Models;
using Microsoft.AspNetCore.Mvc;

namespace BoilerplatePro.Api.Interfaces;

public interface ICountriesController
{
    Task<PagedList<CountryDto>> GetCountries(CountryQuery query, PagingQuery paging);
    Task<CountryWithStateProvinces> GetCountry(string iso2);
    Task<Result> EnableCountry( string iso2);
}
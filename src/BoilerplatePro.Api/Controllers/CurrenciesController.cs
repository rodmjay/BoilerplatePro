﻿#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System;
using System.Threading.Tasks;
using BoilerplatePro.Api.Interfaces;
using BoilerplatePro.Base.Common.Middleware.Bases;
using BoilerplatePro.Base.Common.Models;
using BoilerplatePro.Base.Currencies.Interfaces;
using BoilerplatePro.Base.Currencies.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BoilerplatePro.Api.Controllers;

public class CurrenciesController : BaseController, ICurrenciesController
{
    private readonly ICurrencyService _currencyService;

    public CurrenciesController(IServiceProvider serviceProvider, ICurrencyService currencyService) : base(serviceProvider)
    {
        _currencyService = currencyService;
    }

    [HttpGet]
    [AllowAnonymous]
    public async Task<PagedList<CurrencyOutput>> GetCurrencies([FromQuery] CurrencyFilters filters, [FromQuery] PagingQuery paging)
    {
        return await _currencyService.GetCurrencies<CurrencyOutput>(filters, paging);
    }

    [HttpGet("{code}")]
    [AllowAnonymous]
    public async Task<CurrencyDetails> GetCurrency([FromRoute]string code)
    {
        return await _currencyService.GetCurrency<CurrencyDetails>(code);
    }
}
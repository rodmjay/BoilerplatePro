#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System.Threading.Tasks;
using BoilerplatePro.Base.Common.Models;
using BoilerplatePro.Base.Currencies.Models;
using Microsoft.AspNetCore.Mvc;

namespace BoilerplatePro.Api.Interfaces;

public interface ICurrenciesController
{
    Task<PagedList<CurrencyOutput>> GetCurrencies([FromQuery] CurrencyFilters filters, [FromQuery] PagingQuery paging);
    Task<CurrencyDetails> GetCurrency([FromRoute] string code);
}
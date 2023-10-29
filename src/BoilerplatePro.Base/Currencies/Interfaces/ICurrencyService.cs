#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System.Threading.Tasks;
using BoilerplatePro.Base.Common.Models;
using BoilerplatePro.Base.Common.Services.Interfaces;
using BoilerplatePro.Base.Currencies.Entities;
using BoilerplatePro.Base.Currencies.Models;

namespace BoilerplatePro.Base.Currencies.Interfaces;

public interface ICurrencyService : IService<Currency>
{
    Task<PagedList<T>> GetCurrencies<T>(CurrencyFilters filters, PagingQuery paging) where T : CurrencyOutput;
    Task<T> GetCurrency<T>(string currencyCode) where T : CurrencyOutput;
}
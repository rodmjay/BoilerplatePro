#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System.Threading.Tasks;
using BoilerplatePro.Api.Interfaces;
using BoilerplatePro.Base.Common.Models;
using BoilerplatePro.Base.Currencies.Models;
using NUnit.Framework;

namespace Boilerplate.Api.Testing.Tests;

[TestFixture]
public class CurrenciesControllerTest : BaseApiTest, ICurrenciesController
{
    public Task<PagedList<CurrencyOutput>> GetCurrencies(CurrencyFilters filters, PagingQuery paging)
    {
        throw new System.NotImplementedException();
    }

    public Task<CurrencyDetails> GetCurrency(string code)
    {
        throw new System.NotImplementedException();
    }
}
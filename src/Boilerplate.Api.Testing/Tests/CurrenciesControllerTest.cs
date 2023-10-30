#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System.Threading.Tasks;
using BoilerplatePro.Api.Interfaces;
using BoilerplatePro.Base.Common.Helpers;
using BoilerplatePro.Base.Common.Models;
using BoilerplatePro.Base.Currencies.Entities;
using BoilerplatePro.Base.Currencies.Models;
using BoilerplatePro.Base.Timezones.Models;
using Microsoft.AspNetCore.Http;
using NUnit.Framework;

namespace Boilerplate.Api.Testing.Tests;

[TestFixture]
public class CurrenciesControllerTest : BaseApiTest, ICurrenciesController
{
    [TestFixture]
    public class TheGetCurrenciesMethod : CurrenciesControllerTest
    {
        [Test]
        public async Task CanGetCurrencies()
        {
            var result = await GetCurrencies(new CurrencyFilters(), new PagingQuery());
            Assert.AreEqual(178, result.TotalItems);
        }
    }

    [TestFixture]
    public class TheGetCurrencyMethod : CurrenciesControllerTest
    {
        [Test]
        public async Task CanGetCurrency()
        {
            var currency = await GetCurrency("USD");
            Assert.AreEqual(1, currency.Countries.Count);
        }
    }
    public Task<PagedList<CurrencyOutput>> GetCurrencies(CurrencyFilters filters, PagingQuery paging)
    {
        var querystring = UrlHelper.CombineObjectsToUrl(filters, paging);
        return DoGetAnonymous<PagedList<CurrencyOutput>>($"/v1.0/currencies?{querystring}");
    }

    public Task<CurrencyDetails> GetCurrency(string code)
    {
        return DoGetAnonymous<CurrencyDetails>($"/v1.0/currencies/{code}");
    }
}
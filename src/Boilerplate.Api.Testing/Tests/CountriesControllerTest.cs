﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoilerplatePro.Api.Interfaces;
using BoilerplatePro.Base.Common.Helpers;
using BoilerplatePro.Base.Common.Models;
using BoilerplatePro.Base.Geography.Models;
using Microsoft.AspNetCore.Http;
using NUnit.Framework;

namespace Boilerplate.Api.Testing.Tests
{
    [TestFixture]
    public class CountriesControllerTest : BaseApiTest, ICountriesController
    {
        [TestFixture]
        public class TheGetCountriesMethod : CountriesControllerTest
        {
            [Test]
            public async Task CanGetCountries()
            {
                var countries = await GetCountries(new CountryQuery(), new PagingQuery());

                Assert.IsNotNull(countries);
            }
        }

        [TestFixture]
        public class TheGetCountryMethod : CountriesControllerTest
        {
            [Test]
            public async Task CanGetCountry()
            {
                var country = await GetCountry("us");

                Assert.IsNotNull(country);
            }
        }

        public Task<PagedList<CountryDto>> GetCountries(CountryQuery query, PagingQuery paging)
        {
            var querystring = UrlHelper.CombineObjectsToUrl(query, paging);
            return DoGet<PagedList<CountryDto>>($"v1.0/countries/?{querystring}");
        }

        public Task<CountryWithStateProvinces> GetCountry(string iso2)
        {
            return DoGet<CountryWithStateProvinces>($"v1.0/countries/{iso2}");
        }

        public Task<Result> EnableCountry(string iso2)
        {
            throw new NotImplementedException();
        }
    }
}

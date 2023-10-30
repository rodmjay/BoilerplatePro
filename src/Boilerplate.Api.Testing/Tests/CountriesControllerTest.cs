using System.Threading.Tasks;
using BoilerplatePro.Api.Interfaces;
using BoilerplatePro.Base.Common.Helpers;
using BoilerplatePro.Base.Common.Models;
using BoilerplatePro.Base.Geography.Models;
using BoilerplatePro.Testing.TestCaseSources;
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
                var countries = await GetCountries(new CountryFilters(), new PagingQuery());

                Assert.IsNotNull(countries);
            }
        }

        [TestFixture]
        public class TheGetCountryMethod : CountriesControllerTest
        {
            [TestCaseSource(typeof(CountryTestCases), nameof(CountryTestCases.CountriesWithStateProvinceCounts))]
            public async Task CanGetCountry(string iso2, int count)
            {
                var country = await GetCountry(iso2);

                Assert.IsNotNull(country);

                Assert.AreEqual(count, country.StateProvinces.Count);
            }
        }

        [TestFixture]
        public class TheEnableCountryMethod : CountriesControllerTest
        {
            [Test]
            public async Task CanEnableCountry()
            {
                var result = await EnableCountry("US");
                Assert.IsNotNull(result);
                Assert.IsTrue(result.Succeeded);

            }
        }

        [TestFixture]
        public class TheDisableCountryMethod : CountriesControllerTest
        {
            [Test]
            public async Task CanDisableCountry()
            {
                var enabledResult = await EnableCountry("US");
                Assert.IsTrue(enabledResult.Succeeded);

                var result = await DisableCountry("US");
                Assert.IsNotNull(result);
                Assert.IsTrue(result.Succeeded);
            }
        }

        public Task<PagedList<CountryDetails>> GetCountries(CountryFilters filters, PagingQuery paging)
        {
            var querystring = UrlHelper.CombineObjectsToUrl(filters, paging);
            return DoGetAnonymous<PagedList<CountryDetails>>($"v1.0/countries/?{querystring}");
        }

        public Task<CountryWithStateProvincesOutput> GetCountry(string iso2)
        {
            return DoGet<CountryWithStateProvincesOutput>($"v1.0/countries/{iso2}");
        }

        public Task<Result> EnableCountry(string iso2)
        {
            return DoPatch<Result>($"v1.0/countries/{iso2}/enable");
        }

        public Task<Result> DisableCountry(string iso2)
        {
            return DoPatch<Result>($"v1.0/countries/{iso2}/disable");
        }
    }
}

using System.Threading.Tasks;
using BoilerplatePro.Api.Interfaces;
using BoilerplatePro.Base.Common.Helpers;
using BoilerplatePro.Base.Common.Models;
using BoilerplatePro.Base.Geography.Models;
using BoilerplatePro.Testing.TestCaseSources;
using Moq;
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

                Assert.That(countries, Is.Not.Null);
            }
        }

        [TestFixture]
        public class TheGetCountryMethod : CountriesControllerTest
        {
            [TestCaseSource(typeof(CountryTestCases), nameof(CountryTestCases.CountriesWithStateProvinceCounts))]
            public async Task CanGetCountry(string iso2, int count)
            {
                var country = await GetCountry(iso2);

                Assert.That(country, Is.Not.Null);

                Assert.That(count, Is.EqualTo(country.StateProvinces.Count));
            }
        }

        [TestFixture]
        public class TheEnableCountryMethod : CountriesControllerTest
        {
            [Test]
            public async Task CanEnableCountry()
            {
                var result = await EnableCountry("US");
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Succeeded, Is.True);

            }
        }

        [TestFixture]
        public class TheDisableCountryMethod : CountriesControllerTest
        {
            [Test]
            public async Task CanDisableCountry()
            {
                var enabledResult = await EnableCountry("US");
                Assert.That(enabledResult.Succeeded, Is.True);

                var result = await DisableCountry("US");
                Assert.That(result, Is.Not.Null);
                Assert.That(result.Succeeded, Is.True);
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

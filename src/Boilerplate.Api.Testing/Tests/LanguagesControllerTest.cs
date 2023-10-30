#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System.Threading.Tasks;
using BoilerplatePro.Api.Interfaces;
using BoilerplatePro.Base.Common.Helpers;
using BoilerplatePro.Base.Common.Models;
using BoilerplatePro.Base.Languages.Models;
using BoilerplatePro.Testing.TestCaseSources;
using NUnit.Framework;

namespace Boilerplate.Api.Testing.Tests;

[TestFixture]
public class LanguagesControllerTest : BaseApiTest, ILanguagesController
{
    [TestFixture]
    public class TheGetLanguagesMethod : LanguagesControllerTest
    {
        [Test]
        public async Task CanGetLanguages()
        {
            var result = await GetLanguages(new LanguageQuery(), new PagingQuery());

            Assert.AreEqual(185, result.TotalItems);
        }
    }

    [TestFixture]
    public class TheGetLanguageMethod : LanguagesControllerTest
    {
        [TestCaseSource(typeof(LanguageTestCases), nameof(LanguageTestCases.LanguagesWithCountryCount))]
        public async Task CanGetLanguage(string language, int countries)
        {
            var result = await GetLanguage(language);

            Assert.AreEqual(countries, result.Countries.Count);
        }
    }

    public Task<PagedList<LanguageDetails>> GetLanguages(LanguageQuery filters, PagingQuery paging)
    {
        var querystring = UrlHelper.CombineObjectsToUrl(filters, paging);
        return DoGetAnonymous<PagedList<LanguageDetails>>($"v1.0/languages?{querystring}");
    }

    public Task<LanguageDetails> GetLanguage(string code2)
    {
        return DoGetAnonymous<LanguageDetails>($"v1.0/languages/{code2}");
    }
}
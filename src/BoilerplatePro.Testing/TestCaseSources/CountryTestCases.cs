﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoilerplatePro.Testing.TestCaseSources
{
    public static class LanguageTestCases
    {
        public static object[] LanguagesWithCountryCount => new object[]
        {
            new object[]
            {
                "EN",
                1
            }
        };
    }
    public static class CountryTestCases
    {
        public static object[] CountriesWithStateProvinceCounts => new object[]
        {
            new object[]
            {
                "US",
                51
            }
        };
    }
}

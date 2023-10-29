#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System.Collections.Generic;
using BoilerplatePro.Base.Geography.Interfaces;
using BoilerplatePro.Base.Languages.Models;

namespace BoilerplatePro.Base.Geography.Models
{
    public class CountryOutput : ICountry
    {
        public string Name { get; set; }

        public string Iso2 { get; set; }

        public string CapsName { get; set; }

        public string Iso3 { get; set; }

        public int? NumberCode { get; set; }

        public int PhoneCode { get; set; }
        public List<LanguageOutput> Languages { get; set; }
    }
}
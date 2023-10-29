#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using BoilerplatePro.Base.Languages.Models;
using System.Collections.Generic;
using BoilerplatePro.Base.Currencies.Models;
using BoilerplatePro.Base.Timezones.Models;

namespace BoilerplatePro.Base.Geography.Models;

public class CountryDetails : CountryOutput
{
    public List<LanguageOutput> Languages { get; set; }
    public List<CurrencyOutput> Currencies { get; set; }
    public List<TimezoneOutput> Timezones { get; set; }
}
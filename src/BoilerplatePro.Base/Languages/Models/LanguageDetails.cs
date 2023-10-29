#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System.Collections.Generic;
using BoilerplatePro.Base.Geography.Models;

namespace BoilerplatePro.Base.Languages.Models;

public class LanguageDetails : LanguageOutput
{
    public List<CountryOutput> Countries { get; set; }
}
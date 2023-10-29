#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System.Collections.Generic;
using BoilerplatePro.Base.Geography.Models;

namespace BoilerplatePro.Base.Currencies.Models;

public class CurrencyDetails : CurrencyOutput
{
    public List<CountryOutput> Countries { get; set; }
}
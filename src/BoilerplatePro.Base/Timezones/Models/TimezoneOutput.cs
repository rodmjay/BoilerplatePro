#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using BoilerplatePro.Base.Timezones.Interfaces;

namespace BoilerplatePro.Base.Timezones.Models;

public class TimezoneOutput : ITimezone
{
    public string Code { get; set; }
    public string Value { get; set; }
    public string Name { get; set; }
}
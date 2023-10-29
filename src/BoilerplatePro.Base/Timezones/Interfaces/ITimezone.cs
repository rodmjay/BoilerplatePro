#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion


namespace BoilerplatePro.Base.Timezones.Interfaces;

public interface ITimezone
{
    string Code { get; set; }
    string Value { get; set; }
    string Name { get; set; }
}
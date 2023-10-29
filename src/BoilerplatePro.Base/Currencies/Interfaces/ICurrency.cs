#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion


namespace BoilerplatePro.Base.Currencies.Interfaces;

public interface ICurrency
{
    string Code { get; set; }
    string Decimals { get; set; }
    string Name { get; set; }
}
#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using BoilerplatePro.Base.Common.Data.Bases;
using BoilerplatePro.Base.Geography.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoilerplatePro.Base.Currencies.Entities;

public class CountryCurrency : BaseEntity<CountryCurrency>
{
    public string CurrencyCode { get; set; }
    public Currency Currency { get; set; }
    public string Iso2 { get; set; }
    public Country Country { get; set; }
    public override void Configure(EntityTypeBuilder<CountryCurrency> builder)
    {
        builder.HasKey(x => new {x.Iso2, x.CurrencyCode});

        builder.HasOne(x => x.Currency)
            .WithMany(x => x.Countries)
            .HasForeignKey(x => x.CurrencyCode);

        builder.HasOne(x=>x.Country)
            .WithMany(x=>x.Currencies)
            .HasForeignKey(x => x.Iso2);

    }
}
#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using BoilerplatePro.Base.Common.Data.Bases;
using BoilerplatePro.Base.Geography.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoilerplatePro.Base.Timezones.Entities;

public class CountryTimezone : BaseEntity<CountryTimezone>
{
    public string TimezoneCode { get; set; }
    public string TimezoneName { get; set; }
    public Timezone Timezone { get; set; }
    public string Iso2 { get; set; }
    public Country Country { get; set; }
    public override void Configure(EntityTypeBuilder<CountryTimezone> builder)
    {
        builder.HasKey(x => new { x.Iso2, x.TimezoneCode });

        builder.HasOne(x => x.Country)
            .WithMany(x => x.Timezones)
            .HasForeignKey(x => x.Iso2);

        builder.HasOne(x => x.Timezone)
            .WithMany(x => x.Countries)
            .HasForeignKey(x => new { x.TimezoneCode, x.TimezoneName });
    }
}
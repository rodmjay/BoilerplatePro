#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using BoilerplatePro.Base.Common.Data.Bases;
using BoilerplatePro.Base.Users.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoilerplatePro.Base.Geography.Entities
{
    public class EnabledCountry : BaseEntity<EnabledCountry>
    {
        public string Iso2 { get; set; }
        public Country Country { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public override void Configure(EntityTypeBuilder<EnabledCountry> builder)
        {
            builder.HasKey(x => x.Iso2);

            builder.HasOne(x => x.Country)
                .WithMany(x => x.Users)
                .HasForeignKey(x => x.Iso2);

            builder.HasOne(x => x.User)
                .WithMany(x => x.EnabledCountries)
                .HasForeignKey(x=>x.UserId);
        }
    }
}
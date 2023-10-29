#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System.Collections.Generic;
using BoilerplatePro.Base.Common.Data.Bases;
using BoilerplatePro.Base.Geography.Entities;
using BoilerplatePro.Base.Timezones.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoilerplatePro.Base.Timezones.Entities
{
    public class Timezone : BaseEntity<Timezone>, ITimezone
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string Name { get; set; }

        public ICollection<CountryTimezone> Countries { get; set; }

        public override void Configure(EntityTypeBuilder<Timezone> builder)
        {
            builder.HasKey(x => new{x.Code, x.Name});
        }
    }
}
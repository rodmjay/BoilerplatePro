﻿#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using BoilerplatePro.Base.Common.Data.Bases;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoilerplatePro.Base.Currencies.Entities
{
    public class Currency : BaseEntity<Currency>
    {
        public string Code { get; set; }
        public string Number { get; set; }
        public string Decimals { get; set; }
        public string Name { get; set; }

        public override void Configure(EntityTypeBuilder<Currency> builder)
        {
            builder.HasKey(x => x.Code);
        }
    }
}
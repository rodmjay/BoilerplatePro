﻿#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using BoilerplatePro.Base.Common.Data.Enums;
using BoilerplatePro.Base.Common.Data.Interfaces;
using BoilerplatePro.Base.Users.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoilerplatePro.Base.Users.Entities
{
    public class Role : IdentityRole<int>, IObjectState, IRole, IEntityTypeConfiguration<Role>
    {
        public ICollection<UserRole> UserRoles { get; set; }
        public ICollection<RoleClaim> RoleClaims { get; set; }

        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.UserRoles)
                .WithOne(x => x.Role)
                .HasForeignKey(x => x.RoleId);

            builder.HasMany(x => x.RoleClaims)
                .WithOne(x => x.Role)
                .HasForeignKey(x => x.RoleId);
        }

        [NotMapped] public ObjectState ObjectState { get; set; }
    }
}
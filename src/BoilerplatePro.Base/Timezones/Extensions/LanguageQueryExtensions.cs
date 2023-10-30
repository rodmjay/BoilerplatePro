#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System;
using System.Linq.Expressions;
using BoilerplatePro.Base.Common.Queries;
using BoilerplatePro.Base.Timezones.Entities;
using BoilerplatePro.Base.Timezones.Models;

namespace BoilerplatePro.Base.Timezones.Extensions
{
    public static class TimezoneFiltersExtensions
    {
        public static Expression<Func<Timezone, bool>> GetExpression(this TimezoneFilters filters)
        {
            var expr = PredicateBuilder.True<Timezone>();

            return expr;
        }
    }
}
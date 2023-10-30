#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using BoilerplatePro.Base.Common.Queries;
using BoilerplatePro.Base.Geography.Entities;
using BoilerplatePro.Base.Geography.Models;
using System;
using System.Linq.Expressions;

namespace BoilerplatePro.Base.Geography.Extensions
{
    public static class CountryFiltersExtensions
    {
        public static Expression<Func<Country, bool>> GetExpression(this CountryFilters filters)
        {
            var expr = PredicateBuilder.True<Country>();
            if (filters.Name != null)
            {
                expr.And(x => x.Name.Contains(filters.Name));
            }
            return expr;
        }
    }
}
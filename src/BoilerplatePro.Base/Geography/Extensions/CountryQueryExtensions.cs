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
    public static class CountryQueryExtensions
    {
        public static Expression<Func<Country, bool>> GetExpression(this CountryQuery query)
        {
            var expr = PredicateBuilder.True<Country>();

            if (query.Enabled is true)
                expr = expr.And(x => x.EnabledCountry != null);

            if (query.Enabled is false)
                expr = expr.And(x => x.EnabledCountry == null);

            return expr;
        }
    }
}
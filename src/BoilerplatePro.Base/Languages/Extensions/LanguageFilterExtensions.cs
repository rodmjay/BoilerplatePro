#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System;
using System.Linq.Expressions;
using BoilerplatePro.Base.Common.Queries;
using BoilerplatePro.Base.Languages.Entities;
using BoilerplatePro.Base.Languages.Models;

namespace BoilerplatePro.Base.Languages.Extensions
{
    public static class LanguageFilterExtensions
    {
        public static Expression<Func<Language, bool>> GetExpression(this LanguageFilters filters)
        {
            var expr = PredicateBuilder.True<Language>();

            if (filters.Name != null)
            {
                expr.And(x => x.Name.Contains(filters.Name));
            }

            return expr;
        }
    }
}
#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System;
using System.Linq.Expressions;
using BoilerplatePro.Base.Common.Queries;
using BoilerplatePro.Base.Currencies.Entities;
using BoilerplatePro.Base.Currencies.Models;
using BoilerplatePro.Base.Languages.Entities;
using BoilerplatePro.Base.Languages.Models;

namespace BoilerplatePro.Base.Currencies.Extensions
{
    public static class CurrencyFilterExtensions
    {
        public static Expression<Func<Currency, bool>> GetExpression(this CurrencyFilters query)
        {
            var expr = PredicateBuilder.True<Currency>();

            return expr;
        }
    }
}
#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System;
using System.Linq.Expressions;
using BoilerplatePro.Base.Common.Queries;
using BoilerplatePro.Base.Geography.Entities;
using BoilerplatePro.Base.Geography.Models;
using BoilerplatePro.Base.Languages.Entities;
using BoilerplatePro.Base.Languages.Models;

namespace BoilerplatePro.Base.Languages.Extensions
{
    public static class LanguageQueryExtensions
    {
        public static Expression<Func<Language, bool>> GetExpression(this LanguageQuery query)
        {
            var expr = PredicateBuilder.True<Language>();

            return expr;
        }
    }
}
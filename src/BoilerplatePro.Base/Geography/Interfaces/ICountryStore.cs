#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using BoilerplatePro.Base.Common.Models;
using BoilerplatePro.Base.Geography.Entities;
using BoilerplatePro.Base.Geography.Models;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BoilerplatePro.Base.Geography.Interfaces
{
    public interface ICountryStore
    {
        Task<T> GetCountry<T>(string iso2) where T : CountryDto;

        Task<PagedList<T>> GetCountries<T>(Expression<Func<Country, bool>> predicate, PagingQuery paging)
            where T : CountryDto;
    }
}
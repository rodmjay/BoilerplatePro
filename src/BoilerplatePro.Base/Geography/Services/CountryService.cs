#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using BoilerplatePro.Base.Common.Data.Interfaces;
using BoilerplatePro.Base.Common.Extensions;
using BoilerplatePro.Base.Common.Models;
using BoilerplatePro.Base.Common.Services.Bases;
using BoilerplatePro.Base.Geography.Entities;
using BoilerplatePro.Base.Geography.Interfaces;
using BoilerplatePro.Base.Geography.Models;
using Microsoft.EntityFrameworkCore;

namespace BoilerplatePro.Base.Geography.Services
{
    public class CountryService : BaseService<Country>, ICountryService
    {
        private readonly IRepositoryAsync<StateProvince> _stateProvinceRepo;

        public CountryService(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _stateProvinceRepo = UnitOfWork.RepositoryAsync<StateProvince>();
        }

        public IQueryable<Country> Countries => Repository.Queryable().Include(x => x.EnabledCountry);
        public IQueryable<StateProvince> StateProvinces => _stateProvinceRepo.Queryable();

        public Task<T> GetCountry<T>(string id) where T : CountryDto
        {
            return Countries.Where(x => x.Iso2 == id)
                .ProjectTo<T>(ProjectionMapping)
                .AsNoTracking()
                .FirstOrDefaultAsync();
        }

        public Task<PagedList<T>> GetCountries<T>(Expression<Func<Country, bool>> predicate, PagingQuery paging)
            where T : CountryDto
        {
            return this.PaginateAsync<Country, T>(predicate, paging);
        }

        public Task<List<T>> GetStateProvincesForCountry<T>(string iso2) where T : StateProvinceDto
        {
            return StateProvinces.Where(x => x.Iso2 == iso2).ProjectTo<T>(ProjectionMapping)
                .AsNoTracking()
                .ToListAsync();
        }

        private string GetLogMessage(string message, [CallerMemberName] string callerName = null)
        {
            return $"[{nameof(CountryService)}.{callerName}] - {message}";
        }
    }
}
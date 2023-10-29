#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System;
using System.Linq;
using System.Threading.Tasks;
using BoilerplatePro.Base.Common.Data.Enums;
using BoilerplatePro.Base.Common.Models;
using BoilerplatePro.Base.Common.Services.Bases;
using BoilerplatePro.Base.Geography.Entities;
using BoilerplatePro.Base.Geography.Interfaces;
using BoilerplatePro.Base.Geography.Models;
using Microsoft.EntityFrameworkCore;

namespace BoilerplatePro.Base.Geography.Services
{
    public class EnabledCountryService : BaseService<EnabledCountry>, IEnabledCountryService
    {
        private readonly GeographyErrorDescriber _errors;

        public EnabledCountryService(
            GeographyErrorDescriber errors,
            IServiceProvider serviceProvider) : base(serviceProvider)
        {
            _errors = errors;
        }

        public IQueryable<EnabledCountry> EnabledCountries => Repository.Queryable();

        public async Task<Result> EnableCountry(string iso2)
        {
            if (await EnabledCountries.Where(x => x.Iso2 == iso2).AnyAsync())
                return Result.Failed(_errors.CountryAlreadyEnabled());

            var enabledCountry = new EnabledCountry
            {
                Iso2 = iso2,
                ObjectState = ObjectState.Added
            };

            var changes = await Repository.InsertAsync(enabledCountry, true);
            if (changes < 1) return Result.Failed(_errors.EnableCountryError());

            return Result.Success(iso2);
        }
    }
}
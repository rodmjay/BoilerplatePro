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

        public async Task<Result> EnableCountry(int userId, string iso2)
        {
            var enabledCountry = await EnabledCountries.Where(x => x.Iso2 == iso2 && x.UserId == userId).FirstOrDefaultAsync();
            if (enabledCountry != null)
            {
              return Result.Failed(_errors.CountryAlreadyEnabled());
            }

            enabledCountry = new EnabledCountry()
            {
                ObjectState = ObjectState.Added,
                UserId = userId,
                Iso2 = iso2
            };

            var records = await Repository.InsertAsync(enabledCountry, true);
            if (records > 0)
                return Result.Success(iso2);

            return Result.Failed(_errors.EnableCountryError());
        }

        public async Task<Result> DisableCountry(int userId, string iso2)
        {
            var enabledCountry = await EnabledCountries.Where(x => x.Iso2 == iso2 && x.UserId == userId).FirstOrDefaultAsync();
            if (enabledCountry == null)
            {
                return Result.Failed(_errors.CountryAlreadyEnabled());
            }
            var succeeded = await Repository.DeleteAsync(enabledCountry, true);
            if (succeeded)
                return Result.Success(iso2);

            return Result.Failed(_errors.DisableCountryError());
        }
    }
}
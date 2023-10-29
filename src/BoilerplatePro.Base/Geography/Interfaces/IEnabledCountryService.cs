#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using BoilerplatePro.Base.Common.Models;
using BoilerplatePro.Base.Common.Services.Interfaces;
using BoilerplatePro.Base.Geography.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace BoilerplatePro.Base.Geography.Interfaces
{
    public interface IEnabledCountryService : IService<EnabledCountry>
    {
        IQueryable<EnabledCountry> EnabledCountries { get; }

        Task<Result> EnableCountry(int userId, string iso2);
        Task<Result> DisableCountry(int userId, string iso2);
    }
}
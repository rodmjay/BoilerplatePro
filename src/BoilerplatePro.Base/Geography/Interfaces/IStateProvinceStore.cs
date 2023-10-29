#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using BoilerplatePro.Base.Geography.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoilerplatePro.Base.Geography.Interfaces
{
    public interface IStateProvinceStore
    {
        Task<List<T>> GetStateProvincesForCountry<T>(string id) where T : StateProvinceOutput;
    }
}
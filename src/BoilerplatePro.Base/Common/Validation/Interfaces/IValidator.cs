#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using BoilerplatePro.Base.Common.Data.Interfaces;
using BoilerplatePro.Base.Common.Services.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace BoilerplatePro.Base.Common.Validation.Interfaces
{
    public interface IValidator<T> where T : class, IObjectState
    {
        ValidationResult Validate(IService<T> service, T account, string value);
    }
}
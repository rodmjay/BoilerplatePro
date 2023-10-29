#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using BoilerplatePro.Base.Common.Data.Contexts;
using Microsoft.EntityFrameworkCore.Design;

namespace BoilerplatePro.Base.Common.Data.Interfaces
{
    public interface IApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
    }
}
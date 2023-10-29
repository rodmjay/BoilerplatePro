#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using AutoMapper;
using BoilerplatePro.Base.Common.Data.Interfaces;

namespace BoilerplatePro.Base.Common.Services.Interfaces
{
    public interface IService<TEntity> where TEntity : class, IObjectState
    {
        public MapperConfiguration ProjectionMapping { get; }
        public IRepositoryAsync<TEntity> Repository { get; }
    }
}
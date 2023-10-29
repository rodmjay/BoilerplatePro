#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System;
using AutoMapper;
using BoilerplatePro.Base.Common.Data.Interfaces;
using BoilerplatePro.Base.Common.Services.Interfaces;
using BoilerplatePro.Base.Common.Settings;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace BoilerplatePro.Base.Common.Services.Bases
{
    public abstract class BaseService
    {
        protected BaseService(IServiceProvider serviceProvider)
        {
            UnitOfWork = serviceProvider.GetRequiredService<IUnitOfWorkAsync>();
            ProjectionMapping = serviceProvider.GetRequiredService<MapperConfiguration>();
            Mapper = serviceProvider.GetRequiredService<IMapper>();
            Cache = serviceProvider.GetRequiredService<IDistributedCache>();
            AppSettings = serviceProvider.GetRequiredService<IOptions<AppSettings>>().Value;
        }

        protected AppSettings AppSettings { get; }
        public MapperConfiguration ProjectionMapping { get; }
        protected IMapper Mapper { get; }
        protected IUnitOfWorkAsync UnitOfWork { get; }
        protected IDistributedCache Cache { get; }
    }

    public abstract class BaseService<TEntity> : BaseService, IService<TEntity> where TEntity : class, IObjectState
    {
        protected BaseService(IServiceProvider serviceProvider) : base(serviceProvider)
        {
            Repository = UnitOfWork.RepositoryAsync<TEntity>();
        }

        public IRepositoryAsync<TEntity> Repository { get; }
    }
}
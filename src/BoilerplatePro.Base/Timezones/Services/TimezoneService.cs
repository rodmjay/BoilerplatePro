using System;
using System.Linq;
using System.Threading.Tasks;
using BoilerplatePro.Base.Common.Extensions;
using BoilerplatePro.Base.Common.Models;
using BoilerplatePro.Base.Common.Services.Bases;
using BoilerplatePro.Base.Timezones.Entities;
using BoilerplatePro.Base.Timezones.Extensions;
using BoilerplatePro.Base.Timezones.Interfaces;
using BoilerplatePro.Base.Timezones.Models;

namespace BoilerplatePro.Base.Timezones.Services
{
    public class TimezoneService : BaseService<Timezone>, ITimezoneService
    {
        public TimezoneService(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        private IQueryable<Timezone> Timezones => Repository.Queryable();
        public Task<PagedList<T>> GetTimezones<T>(TimezoneFilters filters, PagingQuery paging) where T : TimezoneOutput
        {
            var expr = filters.GetExpression();

            return this.PaginateAsync<Timezone, T>(expr, paging);
        }
    }
}

using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using BoilerplatePro.Base.Common.Extensions;
using BoilerplatePro.Base.Common.Models;
using BoilerplatePro.Base.Common.Services.Bases;
using BoilerplatePro.Base.Currencies.Entities;
using BoilerplatePro.Base.Currencies.Extensions;
using BoilerplatePro.Base.Currencies.Interfaces;
using BoilerplatePro.Base.Currencies.Models;
using Microsoft.EntityFrameworkCore;

namespace BoilerplatePro.Base.Currencies.Services
{
    public class CurrencyService : BaseService<Currency>, ICurrencyService
    {
        public CurrencyService(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        private IQueryable<Currency> Currencies => Repository.Queryable();

        public Task<PagedList<T>> GetCurrencies<T>(CurrencyFilters filters, PagingQuery paging) where T : CurrencyOutput
        {
            var expr = filters.GetExpression();
            return this.PaginateAsync<Currency,T>(expr, paging);
        }

        public Task<T> GetCurrency<T>(string currencyCode) where T : CurrencyOutput
        {
            return Currencies.Where(c => c.Code == currencyCode).ProjectTo<T>(ProjectionMapping).FirstOrDefaultAsync();
        }
    }
}

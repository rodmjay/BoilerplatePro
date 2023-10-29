using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using BoilerplatePro.Base.Common.Extensions;
using BoilerplatePro.Base.Common.Models;
using BoilerplatePro.Base.Common.Services.Bases;
using BoilerplatePro.Base.Languages.Entities;
using BoilerplatePro.Base.Languages.Extensions;
using BoilerplatePro.Base.Languages.Interfaces;
using BoilerplatePro.Base.Languages.Models;
using Microsoft.EntityFrameworkCore;

namespace BoilerplatePro.Base.Languages.Services
{
    public class LanguageService : BaseService<Language>, ILanguageService
    {
        public LanguageService(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        private IQueryable<Language> Languages => Repository.Queryable();

        public async Task<PagedList<T>> GetLanguages<T>(LanguageQuery filters, PagingQuery query)
        {
            var expr = filters.GetExpression();
            return await this.PaginateAsync<Language, T>(expr, query);
        }

        public Task<T> GetLanguage<T>(string code2)
        {
            return Languages.Where(x=>x.Code2 == code2).ProjectTo<T>(ProjectionMapping).FirstAsync();
        }
    }
}

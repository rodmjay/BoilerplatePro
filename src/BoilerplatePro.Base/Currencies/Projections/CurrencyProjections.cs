using System.Linq;
using AutoMapper;
using BoilerplatePro.Base.Currencies.Entities;
using BoilerplatePro.Base.Currencies.Models;

namespace BoilerplatePro.Base.Currencies.Projections
{
    public class CurrencyProjections : Profile
    {
        public CurrencyProjections()
        {
            CreateMap<Currency, CurrencyOutput>().IncludeAllDerived();

            CreateMap<Currency, CurrencyDetails>()
                .ForMember(x => x.Countries, opt => opt.MapFrom(x => x.Countries.Select(c => c.Country)))
                .IncludeAllDerived();
        }

    }
}

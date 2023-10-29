using AutoMapper;
using BoilerplatePro.Base.Currencies.Entities;
using BoilerplatePro.Base.Currencies.Models;

namespace BoilerplatePro.Base.Currencies.Projections
{
    public class CurrencyProjections : Profile
    {
        public CurrencyProjections()
        {
            CreateMap<Currency, CurrencyOutput>();
        }

    }
}

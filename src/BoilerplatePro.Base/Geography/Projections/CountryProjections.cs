#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using System.Linq;
using AutoMapper;
using BoilerplatePro.Base.Common.Models;
using BoilerplatePro.Base.Geography.Entities;
using BoilerplatePro.Base.Geography.Models;

namespace BoilerplatePro.Base.Geography.Projections
{
    public class CountryProjections : Profile
    {
        public CountryProjections()
        {
            CreateMap<Country, CountryOutput>()
                .IncludeAllDerived();

            CreateMap<Country, CountryDetails>()
                .ForMember(x => x.Languages, opt => opt.MapFrom(x => x.Languages.Select(l => l.Language)))
                .ForMember(x => x.Currencies, opt => opt.MapFrom(x => x.Currencies.Select(l => l.Currency)))
                .ForMember(x => x.Timezones, opt => opt.MapFrom(t => t.Timezones.Select(l => l.Timezone)))
                .IncludeAllDerived();

            CreateMap<Country, CountryWithStateProvincesOutput>()
                .ForMember(x => x.StateProvinces, opt => opt.MapFrom(x => x.StateProvinces))
                .IncludeAllDerived();

            CreateMap<Country, DropdownItem>()
                .ForMember(x => x.Name, opt => opt.MapFrom(x => x.Name))
                .ForMember(x => x.Value, opt => opt.MapFrom(x => x.Iso2));
        }
    }
}
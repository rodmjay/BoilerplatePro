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
                .ForMember(x=>x.Languages, opt=>opt.MapFrom(x=>x.Languages.Select(l=>l.Language)))
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
#region Header

// /*

// Author: Rod Johnson, Architect, rodmjay@gmail.com
// */

#endregion

using AutoMapper;
using BoilerplatePro.Base.Common.Models;
using BoilerplatePro.Base.Geography.Entities;
using BoilerplatePro.Base.Geography.Models;

namespace BoilerplatePro.Base.Geography.Projections
{
    public class StateProvinceProjections : Profile
    {
        public StateProvinceProjections()
        {
            CreateMap<StateProvince, StateProvinceDto>()
                .IncludeAllDerived();

            CreateMap<StateProvince, DropdownItem>()
                .ForMember(x => x.Name, opt => opt.MapFrom(x => x.Name))
                .ForMember(x => x.Value, opt => opt.MapFrom(x => x.Id));
        }
    }
}
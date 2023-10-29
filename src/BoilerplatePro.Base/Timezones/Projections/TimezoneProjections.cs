using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BoilerplatePro.Base.Timezones.Entities;
using BoilerplatePro.Base.Timezones.Models;

namespace BoilerplatePro.Base.Timezones.Projections
{
    public class TimezoneProjections : Profile
    {
        public TimezoneProjections()
        {
            CreateMap<Timezone, TimezoneOutput>().IncludeAllDerived();
        }

    }
}

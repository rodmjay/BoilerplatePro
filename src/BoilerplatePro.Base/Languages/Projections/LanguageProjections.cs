﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BoilerplatePro.Base.Languages.Entities;
using BoilerplatePro.Base.Languages.Models;

namespace BoilerplatePro.Base.Languages.Projections
{
    internal class LanguageProjections : Profile
    {
        public LanguageProjections()
        {
            CreateMap<Language, LanguageOutput>().IncludeAllDerived();

            CreateMap<Language, LanguageDetails>()
                .ForMember(x=>x.Countries, opt=>opt.MapFrom(x=>x.Countries.Select(lc => lc.Country)))
                .IncludeAllDerived();


        }
    }
}

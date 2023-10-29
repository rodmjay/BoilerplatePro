#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System.Collections.Generic;
using System.Threading.Tasks;
using BoilerplatePro.Base.Common.Models;
using BoilerplatePro.Base.Common.Services.Interfaces;
using BoilerplatePro.Base.Languages.Entities;
using BoilerplatePro.Base.Languages.Models;

namespace BoilerplatePro.Base.Languages.Interfaces;

public interface ILanguageService : IService<Language>
{
    Task<PagedList<T>> GetLanguages<T>(LanguageQuery filters, PagingQuery query);
    Task<T> GetLanguage<T>(string code2);
}
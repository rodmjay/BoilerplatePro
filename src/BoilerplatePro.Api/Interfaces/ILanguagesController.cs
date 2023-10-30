#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System.Threading.Tasks;
using BoilerplatePro.Base.Common.Models;
using BoilerplatePro.Base.Languages.Models;
using Microsoft.AspNetCore.Mvc;

namespace BoilerplatePro.Api.Interfaces;

public interface ILanguagesController
{
    Task<PagedList<LanguageDetails>> GetLanguages([FromQuery] LanguageQuery filters, [FromQuery] PagingQuery paging);
    Task<LanguageDetails> GetLanguage([FromRoute] string code2);
}
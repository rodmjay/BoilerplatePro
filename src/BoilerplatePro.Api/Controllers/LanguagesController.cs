#region Header Info

// Copyright 2023 Rod Johnson.  All rights reserved

#endregion

using System;
using System.Threading.Tasks;
using BoilerplatePro.Api.Interfaces;
using BoilerplatePro.Base.Common.Middleware.Bases;
using BoilerplatePro.Base.Common.Models;
using BoilerplatePro.Base.Languages.Interfaces;
using BoilerplatePro.Base.Languages.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BoilerplatePro.Api.Controllers;

public class LanguagesController : BaseController, ILanguagesController
{
    private readonly ILanguageService _languageService;

    public LanguagesController(IServiceProvider serviceProvider, ILanguageService languageService) : base(serviceProvider)
    {
        _languageService = languageService;
    }

    [HttpGet]
    [AllowAnonymous]
    public async Task<PagedList<LanguageDetails>> GetLanguages([FromQuery]LanguageQuery filters, [FromQuery] PagingQuery paging)
    {
        return await _languageService.GetLanguages<LanguageDetails>(filters, paging);
    }

    [HttpGet("{code2}")]
    [AllowAnonymous]
    public async Task<LanguageDetails> GetLanguage([FromRoute]string code2)
    {
        return await _languageService.GetLanguage<LanguageDetails>(code2);
    }
}
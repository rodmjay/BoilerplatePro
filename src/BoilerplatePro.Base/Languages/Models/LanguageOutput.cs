﻿using BoilerplatePro.Base.Languages.Interfaces;

namespace BoilerplatePro.Base.Languages.Models
{
    public class LanguageOutput : ILanguage
    {
        public string Name { get; set; }
        public string Code2 { get; set; }
        public string Code3 { get; set; }
    }
}

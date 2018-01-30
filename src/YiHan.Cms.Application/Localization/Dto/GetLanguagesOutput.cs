﻿using System.Collections.Generic;
using Abp.Application.Services.Dto;

namespace YiHan.Cms.Localization.Dto
{
    public class GetLanguagesOutput : ListResultDto<ApplicationLanguageListDto>
    {
        public string DefaultLanguageName { get; set; }

        public GetLanguagesOutput()
        {
            
        }

        public GetLanguagesOutput(IReadOnlyList<ApplicationLanguageListDto> items, string defaultLanguageName)
            : base(items)
        {
            DefaultLanguageName = defaultLanguageName;
        }
    }
}
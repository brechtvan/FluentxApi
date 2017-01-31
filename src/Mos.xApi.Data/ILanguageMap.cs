﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mos.xApi.Data
{
    public interface ILanguageMap : IDictionary<string, string>
    {
        string GetTranslation(string languageCode);
    }
}
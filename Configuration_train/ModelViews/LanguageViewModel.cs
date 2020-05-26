using Configuration_train.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration_train.ModelViews
{
    public class LanguageViewModel 
    {
        public LanguageViewModel()
        { }

        public LanguageViewModel(Language language) =>
            (Id, LanguageName) = (language.Id, language.LanguageName);

        public int Id { get; set; }

        public string LanguageName { get; set; }
    }
}

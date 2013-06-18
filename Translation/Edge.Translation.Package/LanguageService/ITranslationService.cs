using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edge.Translation.LanguageService
{ 
    public interface ITranslationService
    {
        bool testTranslation(string result);
        bool validateTranslation(string trans);
        string GetPhrase(string language, string phrase);
    }
}

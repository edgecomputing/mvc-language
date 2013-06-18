using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Edge.Translation.LanguageService;


namespace Translation.Service
{
    public static class LanguageConverterExtention
    {
        public static string LanguageConverter(this HtmlHelper helper, string phrase, string language)
        {
            Service.Translater translater = new Translater();
            return translater.GetForText(phrase, language);
        }

        //using the class liberary
        public static string TranslatePhrase(this HtmlHelper helper, string phrase, string language)
        {
            TranslationService ts = new TranslationService();
            return ts.GetPhrase(language, phrase);
        }
    }
}
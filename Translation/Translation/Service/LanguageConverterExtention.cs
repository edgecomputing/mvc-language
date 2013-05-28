using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;


namespace Translation.Service
{
    public static class LanguageConverterExtention
    {
        public static string LanguageConverter(this HtmlHelper helper, string phrase, string language)
        {
            Service.Translater translater = new Translater();
            return translater.GetForText(phrase, language);
        }
    }
}
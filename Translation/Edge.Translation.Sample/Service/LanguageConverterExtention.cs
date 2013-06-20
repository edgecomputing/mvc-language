using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Edge.Translation.LanguageService;
using Edge.Translation;
using PetaPoco;
namespace Translation.Service
{
    public static class LanguageConverterExtention
    {
        private static Database db = new Database("Translation");
        
        //using the class liberary
        public static string TranslatePhrase(this HtmlHelper helper, string phrase)
        {

            phrase = phrase.Trim();
            if (helper.ViewContext.HttpContext.User.Identity.IsAuthenticated)
            {
                string userName = helper.ViewContext.HttpContext.User.Identity.Name;
                TranslationService ts = new TranslationService();
                string language = db.SingleOrDefault<UserProfile>("select * from UserProfile where UserName=@0", userName).LanguageCode;
                string str = ts.GetPhrase(language, phrase);
                if (str != null)
                {
                    return ts.GetPhrase(language, phrase);
                }
                else
                {
                    // try to see if we can find this phrase in english
                    //Transaction t = new Transaction();
                    //Transaction.LanguageCode = langauge;
                    //translation.Phrase = text.Trim();
                    //translation.TranslatedText = text.Trim();
                    //this.Add(translation);

                    //untill implemented
                    return ts.GetPhrase("en", phrase);
                }
            }
            else
                return phrase;
            
        }
        
    }
}
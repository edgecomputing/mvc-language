using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using Translation.Models;

namespace Translation.Service
{
    public class Translater
    {
        private CATSEntities db = new CATSEntities();


        public bool Add(Translation.Models.Translation entity)
        {
            
            db.SaveChanges();
            return true;
        }
        public string GetForText(string text, string langauge)
        {
            var converted = (from v in db.Translations
                               where v.Phrase.Trim() == text.Trim() && v.LanguageCode == langauge
                               select v.TranslatedText).FirstOrDefault();
            if(converted == null)
            {
                // try to see if we can find this phrase in english
                Translation.Models.Translation translation = new Translation.Models.Translation();
                translation.LanguageCode = langauge;
                translation.Phrase = text.Trim();
                translation.TranslatedText = text.Trim();
                this.Add(translation);

                Translation.Models.Translation english = null;
                if(langauge != "en")
                {
                    english = (from v in db.Translations
                                   where v.LanguageCode == "en" && v.Phrase == text
                                   select v).FirstOrDefault();

                    
                    
                }

                // Have an entry for it in the database for english
                if(english == null)
                {
                    translation = new Translation.Models.Translation();
                    translation.LanguageCode = "en";
                    translation.Phrase = translation.TranslatedText = text.Trim();
                    this.Add(translation);
                }
                else
                {
                    return english.TranslatedText;
                }
                return text;
            }
            return converted;
        }


        public List<Translation.Models.Translation> GetAll(string languageCode)
        {
            return (from v in db.Translations
                    where v.LanguageCode == languageCode
                    select v).OrderBy(o=>o.Phrase).ToList();
        }
        
    }
    }

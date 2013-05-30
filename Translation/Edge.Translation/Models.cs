using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edge.Translation
{
    /// <summary>
    /// Represents a single language that the application is required tobe localized to
    /// </summary>
    public class Language
    {
        public int LanguageID { get; set; }
        public string LanguageCode { get; set; }
    }

    /// <summary>
    /// Represents a single 
    /// </summary>
    class Translation
    {
        public int TranslationID { get; set; }
        public int LanguageID { get; set; }
        public string Phrase { get; set; }
        public string TranslatedText { get; set; }
    }
}

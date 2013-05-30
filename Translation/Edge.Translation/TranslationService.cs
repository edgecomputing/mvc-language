using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco;

namespace Edge.Translation
{
    /// <summary>
    /// A singleton class to provide access for client application the underlying translation database
    /// </summary>
    public class TranslationService
    {
        private const string LANGUAGE_TABLE = "Language";
        private const string TRANSLATION_TABLE = "Translation";
        private const string LANGUAGE_ID = "LanguageID";
        private const string TRANSLATION_ID = "TranslationID";
        private const int DEFAULT_LANGUAGE_ID = 0;


        private static TranslationService service;
        private static Database db;

        private TranslationService() { }


        #region Factory Method(s)

        public static TranslationService GetRepository()
        {
            // Create the underlying database access class instance when the service is instantiated.
            // This assumes a connection string named 'Translation' to exist in the configuration file
            // for the client application.

            db = new Database("Translation");
            return service ?? (service = new TranslationService());
        }

        #endregion

        #region Language and Translation CRUD

        public static List<Language> GetLanguages()
        {
            // Good place to put some kind of exception handling here.
            return db.Query<Language>("select * from Language").ToList();
        }

        public static Language GetLanguage(int languageId)
        {
            return db.SingleOrDefault<Language>("select * from Language where LanguageId=@0", languageId);
        }

        public static Language GetLanguage(string languageCode)
        {
            return db.SingleOrDefault<Language>("select * from Language where LanguageCode=@0", languageCode);
        }



        public static void AddNewLanguage(Language language)
        {
            db.Insert(LANGUAGE_TABLE, LANGUAGE_ID, true, language);
        }

        public static void InsertNewTerm(string term)
        {
            // I'm missing something here but could not figure it out right now!
            var item = new Translation { Phrase = term, TranslatedText = "", LanguageID = DEFAULT_LANGUAGE_ID };

            db.Insert(TRANSLATION_TABLE, TRANSLATION_ID, true, item);
        }

        public static void TranslatePhrase(string language, string term)
        {
            // TODO: Insert a new entry into the translation table as a new translatedtext for 'term'
        }

        public static void UpdateTerm(string language, string term)
        {
            // TODO: This one is tricky
        }

        public static void RemoveTerm(string language, string term)
        {
            // TODO: Delete the current term for the specified language. If you wish you can do soft-delete
        }

        #endregion

        #region Translation Service Methods

        public static string GetPhrase(string language, string phrase)
        {
            // TODO: Fetch the translatedtext for the specified term with the specified language
            throw new NotImplementedException();
        }

        public static string[] GetPhrases(string language, string[] phrases)
        {
            // Shold return an the corresponding translated text for each item in phrases and for the specified language
            throw new NotImplementedException();
        }
        #endregion
    }
}

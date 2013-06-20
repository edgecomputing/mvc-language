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

    public sealed class UserProfile
    {

        public Int32 UserProfileID { get; set; }

        public String UserName { get; set; }

        public String Password { get; set; }

        public String FirstName { get; set; }

        public String LastName { get; set; }

        public String GrandFatherName { get; set; }

        public Boolean ActiveInd { get; set; }

        public Boolean LoggedInInd { get; set; }

        public DateTime LogginDate { get; set; }

        public DateTime LogOutDate { get; set; }

        public Int32 FailedAttempts { get; set; }

        public Boolean LockedInInd { get; set; }

        public String LanguageCode { get; set; }

        public String DatePreference { get; set; }

        public String PreferedWeightMeasurment { get; set; }
            
        public String MobileNumber { get; set; }

        public String Email { get; set; }

        public String DefaultTheme { get; set; }

        }
        
}

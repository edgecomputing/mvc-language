using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Edge.Translation;
using Moq;

namespace Edge.Translation
{
    
    public class TestClass
    {
        /* test the modele
         * Language
         */
        
        public void testLanguage()
        {
            
            TranslationService tr = new TranslationService();
            var iTranslationService = new Mock<ITranslationService>();
            iTranslationService.Setup(L => L.testTranslation("tested")).Returns(true);
            
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Edge.Translation.LanguageService;
using Moq;

namespace testMyService.Test
{
    [TestClass]
    public class TestClass
    {
        /* test the modele
         * Language
         */
        [TestMethod]
        public void Can_Test_Translate()
        {
            //Arrange
            Mock<ITranslationService> mock = new Mock<ITranslationService>();
            mock.Setup(m => m.testTranslation(It.IsAny<string>())).Returns((string str) =>
            {
                return str.Contains("a");
            });


            //Act

            var result1=mock.Object.testTranslation("banty");
            var result2 = mock.Object.testTranslation("bnty");

            //Assert

            Assert.IsFalse(result2);
            Assert.IsTrue(result1);
            
           

        }

        [TestMethod]
        public void Can_Validate_Translation()
        {
            //Arrange
            Mock<ITranslationService> mock = new Mock<ITranslationService>();
            mock.Setup(m => m.validateTranslation(It.IsAny<string>())).Returns((string str) =>
            {
                return str.Contains("a");
            });


            //Act

            var result1 = mock.Object.testTranslation("banty");
            var result2 = mock.Object.testTranslation("bnty");

            //Assert

            Assert.IsFalse(result2);
            Assert.IsTrue(result1);
        }
        
        [TestMethod]
        public void Can_Get_Phrase()
        {
            //Arrange
            Mock<ITranslationService> mock = new Mock<ITranslationService>();
            mock.Setup(m=>m.GetPhrase(It.IsAny<string>(),It.IsAny<string>())).Returns("xfgdgf");// =>
            //{
            //    return "ኢሜይል";
            //});
            //Act
            var result1 = mock.Object.GetPhrase("am", "Email");
            //Asert
            Assert.ReferenceEquals(result1, "tsda");
        }

    }

}
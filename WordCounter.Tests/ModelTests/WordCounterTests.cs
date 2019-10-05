using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests {

    [TestClass]
    public class WordCounterTest {
        // [TestMethod]
        // public void RemovePunc_RemovePuncFromPhrase_String()
        // {
        //     //Arrange
        //     CountWords newCount = new CountWords();
        //     //Act
        //     string result = newCount.RemovePunc("I love my cat.");
        //     //Assert
        //     Assert.AreEqual(result, "I love my cat");
        // }

        //   [TestMethod]
        // public void FindWord_FindInputWordInPhrase_Int()
        // {
        //     //Arrange
        //     CountWords newCountWords = new CountWords();
        //     //Act
        //     int result = newCountWords.FindWord("cat" , "I love my cat and cat");
        //     //Assert
        //     Assert.AreEqual(result, 2);
        // }

        [TestMethod]
        public void LettersOnly_MakeLettersOnlyPhrasesTrue_True()
        {
            //Arrange
            CountWords newCount = new CountWords();
            //Act
            bool result = newCount.LettersOnly("I love my cat");
            //Assert
            Assert.AreEqual(result, false);
        }
      

        

    }
}
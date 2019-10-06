using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests {

    [TestClass]
    public class WordCounterTest {
        [TestMethod]
        public void RemovePunc_RemovePuncFromPhrase_String()
        {
            CountWords newCount = new CountWords();
            string result = newCount.RemovePunc("I love my cat.");
            Assert.AreEqual(result, "I love my cat");
        }


        [TestMethod]
        public void LettersOnly_MakeLettersOnlyPhrasesTrue_True()
        { 
            CountWords newCount = new CountWords();
            bool result = newCount.LettersOnly("I love my cat");
            Assert.AreEqual(result, true);
        }
      
        [TestMethod]
            public void LettersOnly_MakeLettersOnlyPhrasesTrue_False()
            {
                CountWords newCount = new CountWords();
                bool result = newCount.LettersOnly("I love my 4");
                Assert.AreEqual(result, false);
            }

        [TestMethod]
        public void FindWord_FindInputWordInPhrase_Int()
        {
            CountWords newCountWords = new CountWords();
            int result = newCountWords.FindWord("cat" , "I love my cat and cat");
            Assert.AreEqual(result, 2);
        }
        

    }
}
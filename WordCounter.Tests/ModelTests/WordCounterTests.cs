using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests {

    [TestClass]
    public class WordCounterTest {
        [TestMethod]
        public void RemovePunc_RemovePuncFromPhrase_String()
        {
            //Arrange
            CountWords newCountWords = new CountWords();
            //Act
            string result = newCountWords.RemovePunc("I love my cat.");
            //Assert
            Assert.AreEqual(result, "I love my cat");
        }

        // [TestMethod]
        // public void FindWord_FindInputWordInPhrase_Int()
        // {
        //     //Arrange
        //     CountWords newCountWords = new CountWords();
        //     //Act
        //     int result = newCountWords.FindWord("cat" , "I love my cat and cat.");
        //     //Assert
        //     Assert.AreEqual(result, 2);
        // }

        // CountWords counter;

        // [TestInitialize]
        // public void Startup () {
        //     counter = new CountWords ();

        // }

        // [TestCleanup]
        // public void TestClean () {
        //     counter = null;
        // }

        // [TestMethod]
        // public void CheckUpperInput_CheckForNonAlphabeticUpperInputs_True () {
        //     Assert.AreEqual (true, counter.CheckUpperInput ("E"));
        // }

        //   [TestMethod]
        // public void FindWord_FindInputWordInText_Int() {
        //     Assert.AreEqual (1, counter.FindWord ("my cat went to the park."));
        // }


    }
}
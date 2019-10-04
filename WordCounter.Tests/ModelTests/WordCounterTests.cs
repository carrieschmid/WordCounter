using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests {

    [TestClass]
    public class WordCounterTest {

        CountWords counter;

        [TestInitialize]
        public void Startup () {
            counter = new CountWords ();

        }

        [TestCleanup]
        public void TestClean () {
            counter = null;
        }

        [TestMethod]
        // public void CheckUpperInput_CheckForNonAlphabeticUpperInputs_True () {
        //     Assert.AreEqual (true, counter.CheckUpperInput ("E"));
        // }

        
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Wordcounter.Models;

namespace Wordcounter.Test
{
  [TestClass]
  public class RepeatCounterTests
  {
    [TestMethod]
    public void ToWordArray_PhraseToWords_True()
    {
      string word = "walk";
      string phrase = "walk the dog";
      string[] output = {"walk", "the", "dog"};
      WordCounter newWordCounter = new WordCounter(word, phrase);
      Assert.AreEqual(output[0], newWordCounter.Phrase[0]);
    }
    [TestMethod]
    public void RepeatChecker_WordAppearsOnce_The()
    {
      string word = "walk";
      string phrase = "walk the dog";
      WordCounter newWordCounter = new WordCounter(word, phrase);
      Assert.AreEqual(1, newWordCounter.RepeatChecker());
    }
  }
}

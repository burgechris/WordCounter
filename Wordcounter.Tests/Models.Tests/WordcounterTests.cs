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
      RepeatCounter newCounter = new RepeatCounter(word, phrase);
      Assert.AreEqual(output[0], newCounter.Phrase[0]);
    }
  }
}

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
      string phrase = "walk the dog";
      string[] output = {"walk", "the", "dog"};
      StrConverter newConverter = new StrConverter(phrase);
      Assert.AreEqual(output[0], newConverter.Phrase[0]);
    }
  }
}

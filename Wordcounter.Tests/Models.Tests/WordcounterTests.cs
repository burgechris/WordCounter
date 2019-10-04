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
    public void RepeatChecker_WordAppearsOnce_True()
    {
      string word = "walk";
      string phrase = "walk the dog";
      WordCounter newWordCounter = new WordCounter(word, phrase);
      Assert.AreEqual(1, newWordCounter.RepeatChecker());
    }
    [TestMethod]
    public void RepeatChecker_ChecksForOnlyExactMatch_True()
    {
      string word = "cat";
      string phrase = "walk the dog to the cathedral";
      WordCounter newWordCounter = new WordCounter(word, phrase);
      Assert.AreEqual(0, newWordCounter.RepeatChecker());
    }
    [TestMethod]
    public void RepeatChecker_ChecksForMultipleMatches_True()
    {
      string word = "dog";
      string phrase = "Walk the dog to play at the dog park";
      WordCounter newWordCounter = new WordCounter(word, phrase);
      Assert.AreEqual(2, newWordCounter.RepeatChecker());
    }
    [TestMethod]
    public void RepeatChecker_CounterIgnoresPunctuation_True()
    {
      string word = "dog";
      string phrase = "Take the dog to play with another dog.";
      WordCounter newWordCounter = new WordCounter(word, phrase);
      Assert.AreEqual(2, newWordCounter.RepeatChecker());
    }
  }
}

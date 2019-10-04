using System.Collections.Generic;

namespace Wordcounter.Models
{
  public class WordCounter
  {
    public string Word { get; set; }
    public string[] Phrase { get; set; }

    public WordCounter(string word, string phrase)
    {
      Word = word;
      Phrase = phrase.Split(' ');
      RepeatChecker();
    }
    public int RepeatChecker()
    {
      int counter = 0;
      char[] trimChars = {',', '.', '?', '!'};
      for(int i = 0; i < Phrase.Length; i++)
      {
        if(Phrase[i].TrimEnd(trimChars) == Word)
        {
          counter ++;
        }
      }
      return counter;
    }
  }
}
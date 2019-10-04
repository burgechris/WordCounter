using System;
using Wordcounter.Models;

namespace Wordcounter
{
    class Program
    {
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Hey There!");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Check to see how many times a word is repeated in a phrase.");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("Please enter a phrase.");
            string phrase = Console.ReadLine().ToLower();
            Console.WriteLine("Please enter a word.");
            string word = Console.ReadLine().ToLower();
            WordCounter newWordCounter = new WordCounter(word, phrase);
            int count = newWordCounter.RepeatChecker();
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("The word '" + word + "' appears " + count + " times.");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ResetColor();
        }
    }
}

using System;
using System.Collections.Generic;

namespace dictionary_of_words
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> wordsWithDefs = new Dictionary<string, string>();

            //Added a few words
            wordsWithDefs.Add("happy", "feeling or showing pleasure or contentment.");
            wordsWithDefs.Add("sad", "feeling or showing sorrow; unhappy.");
            wordsWithDefs.Add("carrot", "a tapering orange-colored root eaten as a vegetable.");

            Console.WriteLine(wordsWithDefs["carrot"]);
            Console.WriteLine("------");
            foreach(KeyValuePair<string, string> word in wordsWithDefs){
                Console.WriteLine($"Word: {word.Key}, Definition: {word.Value}");
            }

            Console.WriteLine("<---Test--->");
        }
    }
}

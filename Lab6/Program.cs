using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Console.WriteLine("Welcome to the Pig Latin Translator!\n");
                Console.WriteLine("Enter a line to be translated: \n");
                string word = Console.ReadLine().ToLower();
                //created an indexofany to show the number of characters a word has before the first vowel in said word
                char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y' };
                int index = word.IndexOfAny(vowels);

                //check if word starts with vowel
                if ((word.StartsWith("a")) || (word.StartsWith("e")) || (word.StartsWith("i")) || (word.StartsWith("o")) || (word.StartsWith("u")))
                {
                    Console.WriteLine(word + "way");
                }

                else //if (index == -1)  
                {
                    string removedConsonants = word.Substring(index);
                    string con = (word.Substring(0, index));
                    Console.WriteLine(removedConsonants + con + "ay\n");
                }

                Console.WriteLine("Do you wish to continue?:  ");

            } while (Console.ReadLine().ToUpper() == "YES");
        }



    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab9
{
    class SortWords
    {
        static void Main(string[] args)
        {
            //CREATES NEAR INFINITE ARRAY
            string[] words = new string[9999999];
            DisplayOrder(words);
        }

        private static void DisplayOrder(params string[] words)
        {
            int wordCount = 0;
            string userInput = " ";

            //KEEPS ASKING FOR USER INPUT UNTIL -999 IS ENTERED
            while (userInput != "-999")
            {
                Write("Enter a word: ");
                userInput = ReadLine();

                //USER INPUT MUST BE A WORD
                if (userInput != "-999" && userInput.All(char.IsLetter))
                {
                    words[wordCount] = userInput;
                    ++wordCount;
                }
                else if (userInput != "-999" && !userInput.All(char.IsLetter))
                {
                    WriteLine("- please enter a word not a number");
                }
            }

            //RESIZE ARRAY TO THE AMOUNT OF SPACES ACTUALLY USED
            Array.Resize(ref words, wordCount);

            //SORT ARRAY IN APLHABETICAL ORDER
            Array.Sort(words);

            //USE LOOP TO DISPLAYE EACH WORD IN ARRAY
            for (int x = 0; x < words.Length; ++x)
            {
                WriteLine("{0} ", words[x]);
            }
        }
    }
}

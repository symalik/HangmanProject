using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanProject
{
    public class DisplayInfo
    {
        public char[] emptyChar;
        public string RandWord()
        {
            var addWord = new RandomWord();
            var input = addWord.GetWord();

            return input;
        }
        

        public string ShowInitialStatus()
        {
            var word = RandWord();
            var wordArray = word.ToCharArray();
            
            Console.WriteLine("***Welcome to Hangman!***");
            Console.WriteLine("Guess the word based on the row of dashes.");
            Console.WriteLine("Try to guess the word before you run out of tries.");

            //Fill hidden word with dashes, and dashes are the same length
            char[] hiddenWord = new char[wordArray.Length];
            for(int i =0; i< wordArray.Length; i++)
            {
                hiddenWord[i] = '_';
            }

            emptyChar = hiddenWord;
            
            //word is the random word and hiddenWord are the dashes
            //Console.WriteLine(word);
            Console.WriteLine(hiddenWord);
            Console.WriteLine($"( "+ hiddenWord.Length + " Letters! )");

            return word;
        }


    }
}

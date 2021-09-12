using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanProject
{
    class Input
    {
        public int Tries = 6;

        public void Guess(char letter, char[] hiddenWord, char[] word)
        {
            for (int i = 0; i < hiddenWord.Length; i++)
            {
                if (letter == hiddenWord[i])
                {
                    word[i] = letter;
                }
            }


            Boolean result = hiddenWord.Contains(letter);
            if (result == true)
            {
                Console.WriteLine(word);
                Console.WriteLine($"Great! {letter.ToString().ToLower()} is in the word!");
            }
            
            if(result == false)
            {
                Console.WriteLine(word);
                Console.WriteLine($"The word does not contain the letter --> {letter}");
                Tries--;
            }

            if(Tries == 1)
            {
                Console.WriteLine("**Hint it's a fruit!**");
            }
            

        }

        public void Guess(string word, string correctWord)
        {
            if (word == correctWord.ToString())
            {
                Console.WriteLine("Congratulations! You have guessed the correct word!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Sorry, that was not the correct word");
                Tries--;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanProject
{
    public class Hangman
    {

        public void Play()
        {
            var initialDisplay = new DisplayInfo();
            var theWord = initialDisplay.ShowInitialStatus();
            
            //The Random Chosen Word
            //Console.WriteLine($"The random word that was chosen is: " + theWord);


            var check = new Input();


            string guess;
            char[] emptyWord = initialDisplay.emptyChar;
            var parsedLetter = ' ';
            char[] magicWord = theWord.ToCharArray();

            while (check.Tries != 0)
            {
                
                Console.WriteLine($"You have " + check.Tries + " tries left!");
                Console.WriteLine("Enter a guess (letter or word): ");
                guess = Console.ReadLine();


                //Sections checks to see if the user entered a letter or a word
                if (char.TryParse(guess, out parsedLetter))
                {
                    check.Guess(parsedLetter, magicWord, emptyWord);
                    
                    //Letter that was entered by user
                    //Console.WriteLine(parsedLetter);
                }
                else
                {
                    check.Guess(guess, theWord);
                    
                    //Check to see if a word was entered instead of a letter
                    //Console.WriteLine("Check: A word was entered instead of a letter");
                }

            }

            Console.WriteLine("Sorry, you Lost!");

        }

    }
}

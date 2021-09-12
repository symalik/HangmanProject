using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanProject
{
    class RandomWord
    {
        public List<string> Words = new List<string>()
        {
          "apple",
          "banana",
          "cherry",
          "mango",
          "orange",
          "pear",
          "strawberry",
          "watermelon",
        };

        public string GetWord()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, Words.Count);
            return Words[randomIndex];
        }
    }
}

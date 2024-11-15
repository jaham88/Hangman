using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanCodeReview.Interfaces
{
    internal class WordGenerator
    {
        public string[] WordCollection { get; set; }
        public Random random { get; set; }
        public string wordFromArray { get; set; }

        public WordGenerator()
        {
            WordCollection = new string[]
            {
                "programmering",
                "utveckling",
                "lärande",
                "teknik",
                "dator",
                "bajskorv",
                "fortnite",
                "warcraft",
                "grafikkort",
                "processor",
                "ramminne",
                "moderkort",
            };

            random = new Random();
        }

        public string GetWord()
        {
            int index = random.Next(WordCollection.Length);
            return WordCollection[index];
        }

        


    }
}

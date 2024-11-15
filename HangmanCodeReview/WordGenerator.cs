using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanCodeReview
{
    internal class WordGenerator
    {
        public string[] WordCollection { get; set; }
        public Random random { get; set; }

        public WordGenerator()
        {
            this.WordCollection = new string[] 
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

            this.random = new Random();
        }

        public string GetWord()
        {
            int index = random.Next(this.WordCollection.Length);
            return WordCollection[index];
        }


    }
}

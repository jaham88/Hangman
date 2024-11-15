using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanCodeReview.GameState
{
    internal class Checks
    {
        

        public void CheckWin(char[] guess, string toGuess)
        {
            if (new string(guess) == toGuess)
            {
                Console.WriteLine($"\nGrattis! Du gissade ordet: {toGuess}");
            }
        }

        public int SetLives()
        {
            return 6;
        }
        public void CheckLives(int lives, string wordtoguess)
        {
            if (lives <= 0)
            {
                Console.Clear();
                Console.WriteLine("Tryck valfri tangent för att avsluta...");
                Console.WriteLine($"\nTyvärr, du har inga liv kvar. Ordet var: {wordtoguess}");

            }  
        }



        public bool CheckContains(List<char> guessedLetters, char guess)
        {
            if (guessedLetters.Contains(guess))
            {
                Console.WriteLine("Du har redan gissat den bokstaven. Försök igen.");
                return true;
            }
            return false;
        }
    }
}

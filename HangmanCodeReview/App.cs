using HangmanCodeReview.Display;
using HangmanCodeReview.GameState;

namespace HangmanCodeReview
{
    internal class App
    {

        public void Run()
        {
            int lives;
            int counter = 0;
            
            var check = new Checks();
            var wordGen = new WordGenerator();
            var drawHangman = new PrintHangman();

            string wordToGuess = wordGen.GetWord();
            char[] guessedWord = new string('_', wordToGuess.Length).ToCharArray();

            lives = check.CheckSetLives();
            List<char> guessedLetters = new List<char>();

            
            while (lives > 0 && new string(guessedWord) != wordToGuess)
            {
                if (counter != 0)
                {
                    Console.Clear();
                    drawHangman.DrawHangman(lives);
                }
                Console.WriteLine("\nOrdet: " + new string(guessedWord));
                Console.WriteLine("Gissade bokstäver: " + string.Join(", ", guessedLetters));
                Console.WriteLine($"Liv kvar: {lives}");
                Console.Write("Gissa EN bokstav: ");
                string input = Console.ReadLine().ToLower();

                if (string.IsNullOrEmpty(input) || input.Length > 1 || !char.IsLetter(input[0]))
                {
                    Console.WriteLine("Använda endast bokstäver.");
                    continue;
                }

                char guess = input[0];

                if (check.CheckContains(guessedLetters, guess))
                {
                    continue;                                                                       
                }
                
                guessedLetters.Add(guess);

                if (wordToGuess.Contains(guess))
                {
                    for (int i = 0; i < wordToGuess.Length; i++)
                    {
                        if (wordToGuess[i] == guess)
                        {
                            guessedWord[i] = guess;
                        }
                    }
                    Console.WriteLine("Rätt gissat!");
                }
                else
                {
                    lives--;
                    Console.WriteLine("Fel gissat! Du förlorade ett liv.");
                }
                counter++;
                


            }

            check.CheckWin(guessedWord, wordToGuess);
            check.CheckLives(lives, wordToGuess);
            drawHangman.DrawHangman(lives);
            
            

        }

        
    }
}

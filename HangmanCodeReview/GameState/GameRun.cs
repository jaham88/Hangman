using HangmanCodeReview.Display;
using HangmanCodeReview.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanCodeReview.GameState
{
    internal class GameRun
    {
        public int lives;
        public int counter = 0;
        public char[] guessedWord;
        public char guess;
        public string wordToGuess;
        public List<char>guessedLetters = new List<char>();

        public void Start()
        {
            
            var check = new Checks();
            var wordGen = new WordGenerator();
            var drawHangman = new PrintHangman();

            wordToGuess = wordGen.GetWord();
            guessedWord = new string('_', wordToGuess.Length).ToCharArray();

            lives = check.SetLives();

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

                guess = input[0];

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

        }
    }
}

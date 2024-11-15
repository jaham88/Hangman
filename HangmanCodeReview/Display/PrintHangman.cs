using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanCodeReview.Display
{
    internal class PrintHangman
    {

        string gameOver = "GAME OVER !";
        bool IsRed = true;


        public void DrawHangman(int lives) 
        {
            switch (lives)
            {
                case 6:
                    Console.WriteLine(@"        
    +---+
    |   |
        |
        |
        |
________|");
                    break;
                case 5:
                    Console.WriteLine(@"        
    +---+
    |   |
    o   |
        |
        |
________|");
                    break;
                case 4:
                    Console.WriteLine(@"        
    +---+
    |   |
    o   |
    |   |
        |
________|");
                    break;
                case 3:
                    Console.WriteLine(@"        
    +---+
    |   |
    o   |
   /|   |
        |
________|");
                    break;
                case 2:
                    Console.WriteLine(@"        
    +---+
    |   |
    o   |
   /|\  |
        |
________|");
                    break;
                case 1:
                    Console.WriteLine(@"        
    +---+
    |   |
    o   |
   /|\  |
   /    |
________|");
                    break;
                case 0:
                    Console.WriteLine(@"        
    +---+
    |   |
    o   |
   /|\  |
   / \  |
________|");
                    
                    while (!Console.KeyAvailable)
                    {
                        Console.CursorVisible = false;
                        if (IsRed)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                        }
                        else
                        {
                            Console.ResetColor();
                        }
                        Console.SetCursorPosition(0, 10);
                        Console.WriteLine(gameOver);
                        Console.ResetColor(); 

                        IsRed = !IsRed; 
                        Thread.Sleep(500); 
                        
                    }
                    //Console.SetCursorPosition (0,0);
                    Console.CursorVisible = true;
                    break;
                default:
                    break;
            }
            
            
        }


    }
}

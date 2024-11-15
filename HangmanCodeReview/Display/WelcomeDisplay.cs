using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanCodeReview.Display
{
    internal class WelcomeDisplay
    {


        public void HangManFigure()
        {
            Console.CursorVisible = false;

            Console.WriteLine("        +---+");
            Thread.Sleep(500);

            
            Console.WriteLine("        |   |");
            Thread.Sleep(500);

            
            Console.WriteLine("        o   |");
            Thread.Sleep(500);

            
            Console.WriteLine("       /|\\  |");
            Thread.Sleep(500);

            
            Console.WriteLine("       / \\  |");
            Thread.Sleep(500);

            
            Console.WriteLine("     _______|");
            Console.WriteLine();

            Console.WriteLine("Välkommen till Hänga gubbe!");
            Console.WriteLine("Du har totalt 6 liv. Gissa bokstäver för att hitta rätt ord.");

            Console.CursorVisible = true;

        }

    }
}

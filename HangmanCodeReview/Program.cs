
using HangmanCodeReview.Display;

namespace HangmanCodeReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var showHangMan = new WelcomeDisplay();
            showHangMan.HangManFigure();

            App app = new App();
            app.Run();
        }
    }
}

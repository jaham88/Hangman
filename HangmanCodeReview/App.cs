using HangmanCodeReview.Display;
using HangmanCodeReview.GameState;
using HangmanCodeReview.Interfaces;

namespace HangmanCodeReview
{
    internal class App
    {
        private Checks _checks;
        private PrintHangman _printHangman;
        private GameRun _gameRun;
        private WelcomeDisplay _welcomeDisplay;

        public App()
        {
            this._checks = new Checks();
            this._printHangman = new PrintHangman();
            this._gameRun = new GameRun();
            this._welcomeDisplay = new WelcomeDisplay();
        }
        public void Run()
        {
            _welcomeDisplay.HangManFigure();

            _gameRun.Start();

            _checks.CheckWin(_gameRun.guessedWord, _gameRun.wordToGuess);
            _checks.CheckLives(_gameRun.lives, _gameRun.wordToGuess);
            _printHangman.DrawHangman(_gameRun.lives);
            
            

        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.View
{
    internal class GameMessages
    {
        private string welcomeMsg = "Welcome Player. Press any key to start the game!";
        private string enterLetterMsg = "Please enter just one letter";
        private string wrongLetterMsg = "UPS! Wrong letter!";
        private string correctLetterMsg = "Great! This is correct!";

        public string WelcomeMsg { get => welcomeMsg;}
        public string EnterLetterMsg { get => enterLetterMsg;}
        public string WrongLetterMsg { get => wrongLetterMsg;}
        public string CorrectLetterMsg { get => correctLetterMsg;}
    }


}

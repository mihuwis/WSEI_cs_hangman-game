using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.View
{
    internal class GameMessages
    {
        private string welcomeMsg = "\t Welcome Player!!\n Below this line you have hashed (###) name of capitol city.\n Please enter any letter to check if it is part of this name!\n Good Luck!!! ";
        private string enterLetterMsg = "Please enter just one letter";
        private string wrongLetterMsg = "UPS! Wrong letter!";
        private string correctLetterMsg = "Great! This is correct!";
        private string menuMsg = "Game Menu \n \t Press Q to quit the game \n\t Press S to start the game";

        public string WelcomeMsg { get => welcomeMsg;}
        public string EnterLetterMsg { get => enterLetterMsg;}
        public string WrongLetterMsg { get => wrongLetterMsg;}
        public string CorrectLetterMsg { get => correctLetterMsg;}
        public string MenuMsg { get => menuMsg; }
    }


}

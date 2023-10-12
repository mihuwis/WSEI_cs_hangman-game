using Hangman.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.Controler
{
    internal class GameController
    {
        GameMessages gameMesages = new GameMessages();
        InputController inputController = new InputController();

        public void RunTheGame()
        {
            Console.WriteLine(gameMesages.WelcomeMsg);
            Console.WriteLine(gameMesages.EnterLetterMsg);
            string letter = inputController.getInputValueFromUser();
  

            Console.WriteLine("END !!");
            Console.WriteLine(letter);
            Console.WriteLine(letter.Length);
        }
    }
}

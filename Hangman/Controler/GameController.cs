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
        InputValidator inputValidator = new InputValidator();

        public void RunTheGame()
        {
            Console.WriteLine(gameMesages.WelcomeMsg);
            Console.WriteLine(gameMesages.EnterLetterMsg);
            string letter;
            do
            {
                letter = Console.ReadLine();
            } while (inputValidator.ValidateInput(letter));

            Console.WriteLine("END !!");
            Console.WriteLine(letter);
            Console.WriteLine(letter.Length);
        }
    }
}

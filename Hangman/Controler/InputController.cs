using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.Controler
{
    internal class InputController
    {
        InputValidator inputValidator = new InputValidator();

        public string getInputValueFromUser()
        {
            string letter;
            do
            {
                letter = Console.ReadLine();
            } while (inputValidator.ValidateInput(letter));

            return letter;
        }
    }
}

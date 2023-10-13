using Hangman.Model;
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
        GameMessages gameMesages = new();
        CitiesGenerator citiesGenerator = new();
        ListOfCities listOfCities = new();
        InputController inputController = new();
        HashNameController hashNameController; 

        public void MenuController ()
        {
            Console.WriteLine(gameMesages.MenuMsg);
            bool isGameStarted = inputController.getInputValueFromUser() == "s" ? true : false;
            if (isGameStarted)
            {
                RunTheGame();
            }
        }

        public void RunTheGame()
        {
            Console.WriteLine(gameMesages.WelcomeMsg);

            bool isGameFinished = false;

            string capitolToGuess = citiesGenerator.generateCity(listOfCities.Cities);
            Console.WriteLine(capitolToGuess);
            hashNameController = new HashNameController(capitolToGuess);
            Console.WriteLine(hashNameController.HashedName);


            while (!isGameFinished)
            {

                Console.WriteLine(hashNameController.HashedName);
                Console.WriteLine(gameMesages.EnterLetterMsg);
                string letter = inputController.getInputValueFromUser();
                if (capitolToGuess.Contains(letter))
                {
                    Console.WriteLine(gameMesages.CorrectLetterMsg);
                }
                else
                {
                    Console.WriteLine(gameMesages.WrongLetterMsg);
                }
             

            }

  
        }

        
    }
}

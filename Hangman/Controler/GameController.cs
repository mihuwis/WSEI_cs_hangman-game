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

        public void RunTheGame()
        {
            bool isGameFinished = false;
            while (!isGameFinished)
            {
                Console.WriteLine(gameMesages.MenuMsg);
                isGameFinished = inputController.getInputValueFromUser() == "s" ? false : true;
                if(!isGameFinished )
                {
                    Console.WriteLine(gameMesages.WelcomeMsg);
                    string capitolToGuess = citiesGenerator.generateCity(listOfCities.Cities);
                    Console.WriteLine(capitolToGuess);
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
}

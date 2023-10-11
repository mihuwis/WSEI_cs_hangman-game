using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.Controler
{
    internal class CitiesGenerator
    {
        public string generateCity(List<string> listOfCities)
        {
            Random r = new Random();
            int randomInt = r.Next(listOfCities.Count);
            return listOfCities[randomInt];
        }
    }
}

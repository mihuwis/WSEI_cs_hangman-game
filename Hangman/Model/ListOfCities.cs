using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.Model
{
    internal class ListOfCities
    {
        private List<string> cities;

        public ListOfCities()
        {
            cities = new List<string>();
            cities.Add("Warsaw");
            cities.Add("Prag");
            cities.Add("Kabul");
            cities.Add("London");
        }

        public List<string> Cities { get => cities; }
    }
}

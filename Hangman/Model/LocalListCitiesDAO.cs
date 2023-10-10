using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.Model
{
    internal class LocalListCitiesDAO : CitiesDAOInterface
    {
        ListOfCities list = new ListOfCities();
        private List<string> listOfCities;

        public LocalListCitiesDAO()
        {
            listOfCities = list.Cities;
        }

        public List<string> GetAllCities()
        {
            return listOfCities;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.Model
{
    internal interface CitiesDAOInterface
    {
        List<string> GetAllCities();
    }
}

using Hangman.Controler;
using Hangman.Model;
using System.Threading.Channels;

namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CitiesGenerator generator = new CitiesGenerator();
            LocalListCitiesDAO localList = new LocalListCitiesDAO();

            string capitolToGuess = generator.generateCity(localList.GetAllCities());
            Console.WriteLine(capitolToGuess);
        }
    }
}
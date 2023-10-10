using Hangman.Model;
using System.Threading.Channels;

namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {

            LocalListCitiesDAO localListCitiesDAO = new LocalListCitiesDAO();
            Console.WriteLine("Hello, World!");

            List<string> list = localListCitiesDAO.GetAllCities();

            list.ForEach(x => Console.WriteLine(x));
        }
    }
}
using Hangman.Controler;
using Hangman.Model;
using Hangman.View;
using System.Threading.Channels;

namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameController controller = new GameController();
            controller.RunTheGame();




        }
    }
}
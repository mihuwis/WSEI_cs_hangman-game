using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.Controler
{
    internal class InputValidator
    {
        public bool ValidateInput (string letter) {
            return letter == null || letter.Length > 1 || letter.Length < 1 || letter.Any(c => !char.IsLetter(c));
        }
    }
}

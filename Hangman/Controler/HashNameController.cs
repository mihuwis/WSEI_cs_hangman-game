using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman.Controler
{
    internal class HashNameController
    {
        private readonly string _name;
        private char[] _hashedName;

        public HashNameController(string name)
        {
            _name = name;
            _hashedName = HashName(_name);
        }

        private char[] HashName(string name)
        {
            char[] chars = name.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = '#';
            }
            return chars;
        }

        public string Name => _name;

        public char[] HashedName { get => _hashedName;}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeminarskiRadDesignPatternTextIterator
{
    class TextIterator : IIterator
    {
        private string str;
        private string[] splited;
        private int pos;
        private char[] separators = { ' ', '.', ',', '?', '!' };
        public TextIterator(string str)
        {
            this.str = str;
            splited = str.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            pos = 0;
        }


        public string Next()
        {
            return splited[pos++];

        }

        public bool HasNext()
        {
            if (pos == splited.Length)
                return false;
            return true;
        }
    }
}

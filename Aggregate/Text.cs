using System;
using System.Collections.Generic;
using System.Text;

namespace SeminarskiRadDesignPatternTextIterator
{
    class Text : IText
    {
        private string str;
        public Text(string str)
        {
            this.str = str;
        }

        public IIterator CreateIterator()
        {
            return new TextIterator(str);
        }
    }
}

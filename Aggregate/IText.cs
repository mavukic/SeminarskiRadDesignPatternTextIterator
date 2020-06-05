using System;
using System.Collections.Generic;
using System.Text;

namespace SeminarskiRadDesignPatternTextIterator
{
    interface IText
    {
        IIterator CreateIterator();
    }
}

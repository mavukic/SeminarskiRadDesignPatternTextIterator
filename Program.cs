using System;

namespace SeminarskiRadDesignPatternTextIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite neki tekst:");
            IText Text = new Text(Console.ReadLine());
            IIterator iterator = Text.CreateIterator();
            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Next());
            }

;            Console.ReadLine();
        }
    }
}

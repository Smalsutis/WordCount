using System;

namespace WordCount
{
    class Program
    {
        static void Main()
        {
            string entry = Console.ReadLine();
            WordCounter wordCounter = new WordCounter(entry.Split());
            LegthCounter legthCounter = new LegthCounter(entry.Split());

            wordCounter.print();
            legthCounter.print();

            Console.ReadLine();
        }

    }
}

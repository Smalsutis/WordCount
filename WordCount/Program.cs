using System;

namespace WordCount
{
    class Program
    {
        static void Main()
        {
            result(Console.ReadLine());

            Console.ReadLine();
        }

        static void result(string entry)
        {
            LengthCounter lengthCounter = new LengthCounter(entry);
            WordCounter wordCounter = new WordCounter(entry);

            Console.WriteLine("List:" + wordCounter.calculate());
            Console.WriteLine("List:" + lengthCounter.calculate());
        }
    }
}

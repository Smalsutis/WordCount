using System;

namespace WordCount
{
    class Program
    {
        static void Main()
        {
            CalculateString(Console.ReadLine());

            Console.ReadLine();
        }

        static void CalculateString(string entry)
        {
            LengthCounter lengthCounter = new LengthCounter();
            WordCounter wordCounter = new WordCounter();

            Console.WriteLine(wordCounter.calculate(entry));
            Console.WriteLine(lengthCounter.calculate(entry));
        }
    }
}

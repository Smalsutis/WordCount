using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordCount
{
    class LegthCounter
    {
        List<CountLine> list;


        public LegthCounter(string[] entry)
        {
            this.list = new List<CountLine>();

            foreach (string word in entry)
            {
                //Console.WriteLine(word);
                if (list.Exists(line => (int)line.Word == word.Length))
                {
                    this.list.Where(line => (int)line.Word == word.Length).ToList().ForEach(line => line.Count++);
                }
                else
                {
                    this.list.Add(new CountLine { Word = word.Length, Count = 1 });
                }
            }
        }

        internal void print()
        {
            Console.Write("List:");
            foreach (CountLine line in list)
            {
                Console.Write(" " + line);
            };
            Console.WriteLine();
        }

    }
}


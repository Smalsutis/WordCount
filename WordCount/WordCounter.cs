using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordCount
{
    class WordCounter
    {
        List<CountLine> list;


        public WordCounter(string[] entry)
        {
            this.list = new List<CountLine>();

            foreach (string word in entry)
            {
                //Console.WriteLine(word);
                if(list.Exists(line => line.Word.ToString() == word))
                {
                    this.list.Where(line => line.Word.ToString() == word).ToList().ForEach(line => line.Count++);
                }
                else
                {
                    this.list.Add(new CountLine { Word = word, Count = 1 });
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

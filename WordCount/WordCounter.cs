using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordCount
{
    class WordCounter
    {
        private List<CountLine> list;
        private string entry;
        private string returnString;

        public WordCounter(string entry)
        {
            this.list = new List<CountLine>();
            this.entry = entry;
        }

        internal string calculate()
        {
            foreach (string word in entry.Split())
            {
                //Console.WriteLine(word);
                if (list.Exists(line => line.Word.ToString() == word))
                {
                    this.list.Where(line => line.Word.ToString() == word).ToList().ForEach(line => line.Count++);
                }
                else
                {
                    this.list.Add(new CountLine { Word = word, Count = 1 });
                }
            }

            Console.Write("List:");
            foreach (CountLine line in list)
             {
                returnString = returnString + " " + line;
            };

            return returnString;
        }
    }
}

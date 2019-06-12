using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordCount
{
    public class LengthCounter
    {
        private string entry;
        private List<CountLine> list;
        private string returnString;


        public LengthCounter(string entry)
        {
            this.entry = entry;
            this.list = new List<CountLine>();       
        }

        internal string calculate()
        {
            foreach (string word in entry.Split())
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

            Console.Write("List:");
            foreach (CountLine line in list)
            {
                returnString = returnString + " " + line;
            };

            return returnString;
        }

    }
}


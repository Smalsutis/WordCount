using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordCount
{
    public class LengthCounter
    {
        public LengthCounter()
        {
       
        }

        public string calculate(string entry)
        {

            List<CountLine> list = new List<CountLine>();

            foreach (string word in entry.Replace(".","").Replace(",", "").Split())
            {
                //Console.WriteLine(word);
                if (list.Exists(line => (int)line.Word == word.Length))
                {
                    list.Where(line => (int)line.Word == word.Length).ToList().ForEach(line => line.Count++);
                }
                else
                {
                    list.Add(new CountLine { Word = word.Length, Count = 1 });
                }
            }

            string returnString = "";

            foreach (CountLine line in list)
            {
                returnString = returnString + ", " + line;
            };

            return "List:" + returnString;
        }

    }
}


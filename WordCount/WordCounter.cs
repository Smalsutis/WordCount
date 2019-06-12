using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WordCount
{
    public class WordCounter
    {

        public WordCounter()
        {
        }

        public string calculate(string entry)
        {

            List<CountLine> list = new List<CountLine>();

            foreach (string word in entry.Replace(".", "").Replace(",", "").Split())
            {

                if (list.Exists(line => line.Word.ToString() == word))
                {
                    list.Where(line => line.Word.ToString() == word).ToList().ForEach(line => line.Count++);
                }
                else
                {
                    list.Add(new CountLine { Word = word, Count = 1 });
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

using System;
using System.Collections.Generic;
using System.Text;

namespace WordCount
{
    public class CountLine : IEquatable<CountLine>
    {

        public object Word { get; set; }
        public int Count { get; set; }

        public override string ToString()
        {
            return "\"" + Word.ToString() + ", " + Count + "\"";
        }

        public bool Equals(CountLine other)
        {
            if (other == null) return false;
            return (this.Count.Equals(other.Count));
        }
    }
}

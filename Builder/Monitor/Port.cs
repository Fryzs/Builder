using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Port
    {
        public string Type { get; }
        public int Count { get; }

        public Port(string type, int count)
        {
            Type = type;
            Count = count;
        }

        public string GetDescription()
        {
            return $"{Type} x{Count}";
        }
    }

}

using System;
using System.Collections.Generic;
using System.Text;

namespace lv6
{
    class Utilities
    {
        public static List<int> Filter(IEnumerable<int> Enum, Func<int, bool> delegat)
        {
            List<int> list = new List<int>();
            foreach(int var in Enum)
            {
                if (delegat(var)) { list.Add(var); }
            }
            return list;
        }
        
    }
}

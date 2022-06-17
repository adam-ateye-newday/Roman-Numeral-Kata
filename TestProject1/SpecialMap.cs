using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    internal class SpecialMap
    {
        Dictionary<int, string> specialMap = new Dictionary<int, string>() {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" } 
        };

        internal string getSpecial(int input)
        {
            return specialMap[input];
        }

        internal int BiggestSpecialKeyLessThanTheInput(int input)
        {
            foreach (var key in specialMap.Keys)
            {
                if (key <= input)
                {
                    return key;
                }

            }
            return -1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexClass
{
    internal class Class4
    {
       public void FindPatterns(string pattern,string value)
        {
            MatchCollection mc = Regex.Matches(value, pattern);
            Console.WriteLine("The no of matching string inside are: " + mc.Count);
        }
    }
}

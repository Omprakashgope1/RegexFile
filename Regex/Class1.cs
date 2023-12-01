using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexClass
{
    internal class Class1
    {
        String pattern;
        private object input;
        Regex rg;

        public Class1() 
        {
            pattern = @"a(b){2,3}";
            rg = new Regex(pattern);
        }
        public bool IsMatching(string s)
        {
            return rg.IsMatch(s);
              
        }
    }
}

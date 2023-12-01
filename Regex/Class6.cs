using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace RegexClass
{
    internal class Class6
    {
        string pattern;
        Regex rg;
        public Class6() 
        {
            pattern = @"^(https://)?(www\.)?[\w\.%_/]+\.(com|in)$";
            rg = new Regex(pattern);
        }
        public void FindMatch(string s)
        {
            bool bn = rg.IsMatch(s);
            Console.WriteLine("The above string is a match : " + bn);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace RegexClass
{
    internal class Class5
    {
        string pattern;
        Regex rg;
        public Class5() 
        {
            pattern = @"[\w\./\\]+\.(png|gif|jpg|jpeg)$";
            rg = new Regex(pattern);
        }
        public void FindMatch(string s)
        {
            bool found = rg.IsMatch(s);
            Console.WriteLine("The given string is a match : " + found);  
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace RegexClass
{
    
    internal class Class3
    {
        string pattern;
        Regex rg;
        public Class3()
        {
            pattern = @"</?[a-z]+>";
            rg = new Regex(pattern);
        }
        public void FindPattern(string s)
        {
            MatchCollection matchCollection = rg.Matches(s);
            foreach(Match match in matchCollection) 
            {
                Console.WriteLine(match.Value + " ");
            }
        }
        
    }
}

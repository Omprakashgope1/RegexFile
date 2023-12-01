using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace RegexClass
{
    
    internal class Class2
    {
        string pattern;
        public Class2() 
        {
            pattern = @"[a-z_]+[a-z]";  
        }
        public bool FindPattern(string s)
        {
            Match m = Regex.Match(s,pattern);
            return m.Length == 0 ? false : true;
        }
    }
}

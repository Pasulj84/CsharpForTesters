using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;



namespace CsharpForTesters._07_RegEx
{
    internal class regexklas
    {
        public static void Main(string[] args)
        {
            string readText = File.ReadAllText("text1.txt", Encoding.UTF8);

            Regex re = new Regex(@"\d+(,\d{0,2})?(zł|\$|€)");
            
            MatchCollection result = re.Matches(readText);

            foreach (Match r in result)
            {
                Console.WriteLine(r.Value);
            }

            Regex panstwo = new Regex(@"w [A-Z]([a-z]+|[A-Z]+)");

            MatchCollection result2 = panstwo.Matches(readText);

            foreach (Match r in result2)
            {
                Console.WriteLine(r.Value);
            }

            Regex przed = new Regex(@"^p(L)+");

            MatchCollection result3 = przed.Matches(readText);

            foreach (Match r in result3)
            {
                Console.WriteLine(r.Value);
            }
        }
    }
}

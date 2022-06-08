using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace RimNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {    string str1= Console.ReadLine();
            var str = System.IO.File.ReadAllText("diseases.txt");
            string[] ArrLines = str.Split('|');
            int i1 = 0; string ReturnStr = ""; int j = 0;
            foreach (string line in ArrLines)
            {
                if (i1 == 1){ ReturnStr += line + " "; j++;}
                if (j == 3) break;
                int a = 0; Int32.TryParse(line, out a);
                string str2 = Convert.ToString(a);
                if (str1 == str2) i1++;
            }

            Console.WriteLine(ReturnStr);
            Console.ReadKey();
        }
    }
}

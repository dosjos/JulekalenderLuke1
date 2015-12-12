using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace JulekalenderLuke1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(File.ReadAllLines("ID.txt").Where(x => Regex.IsMatch(x, @"^[a-z]{0,3}\d{2,8}[A-Z]{3,}$")).Count());
            


            Console.ReadLine();
        }
    }
}

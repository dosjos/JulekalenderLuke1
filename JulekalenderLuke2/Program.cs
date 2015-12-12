using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulekalenderLuke2
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("Tall.txt");

            const decimal min = 1000;
            decimal fortjenst = 0;

            for (var i = 0; i < lines.Length; i++)
            { 
                lines[i] = lines[i].Replace(".", ",");
            }

            for (var i = 0; i < lines.Length; i++)
            {
                var temp = decimal.Parse(lines[i]);
                if (temp >= min) continue;
                for (var j = i; j < lines.Length; j++)
                {
                    var temp2 = decimal.Parse(lines[j]);

                    if (temp2 - temp > fortjenst)
                    {
                        fortjenst = temp2 - temp;
                    }

                }
            }

            Console.WriteLine(fortjenst);
            Console.ReadLine();
        }
    }
}

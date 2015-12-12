using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luke6
{
    class Program
    {

        private static int sum = 0;
        static void Main(string[] args)
        {
            Brackets(13,0,"");
            Console.WriteLine(sum);
            Console.ReadLine();
        }


        static void Brackets(int openStock, int closeStock, String s)
        {
            if (openStock == 0 && closeStock == 0)
            {
                sum++;
                // Console.WriteLine(s);
            }
            if (openStock > 0)
            {
                Brackets(openStock - 1, closeStock + 1, s + "(");
            }
            if (closeStock > 0)
            {
                Brackets(openStock, closeStock - 1, s + ")");
            }
        }
    }
}

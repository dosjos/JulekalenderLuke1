using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luke9
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            var tall = 28;
            var result = "";

            result = GetValue(tall);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static string GetValue(int tall)
        {
            var result = "";
            int mod;
            do
            {
                mod = tall%26;
                tall = tall/26;
                mod--;
                //if (mod == 0 && tall == 0) break;
                Console.WriteLine("MOD = " + mod + "char = " + (char)(65 + mod) + " tall == " + tall);


                //if (mod == 0) mod = 1; 
                result = (char) (64 + mod) + result;

            } while (tall > 0);

            return result;
        }
    }
}

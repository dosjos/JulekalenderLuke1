using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luke8
{
    class Program
    {
        static void Main(string[] args)
        {

            var sum = 0; //antall primtall
            for (var i = 0; i < 1000; i++)
            {
                //finn om prim

                if (IsPrime(i) && IsPrime(PutMyInDonFlipItAndReverseIt(i)) && !IsPalindrome(i.ToString()))
                {
                    sum++;
                }

            //reverser, finn om fortsatt prim

            //sjekk om !palindrom

            }


            Console.WriteLine(sum);
            Console.ReadLine();
        }

        private static int PutMyInDonFlipItAndReverseIt(int i)
        {
            return int.Parse(new string(("" + i).Reverse().ToArray()));
        }

        private static bool IsPrime(int number)
        {
            var boundary = (int) Math.Floor(Math.Sqrt(number));

            if (number == 1) return false;
            if (number == 2) return true;

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        public static bool IsPalindrome(string value)
        {
            var min = 0;
            var max = value.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                var a = value[min];
                var b = value[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }
    }
}

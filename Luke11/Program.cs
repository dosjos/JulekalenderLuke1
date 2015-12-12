using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luke11
{
    class Program
    {

        private static Dictionary<char, int> _romanMap = new Dictionary<char, int>
{
   {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000}
};

        static void Main(string[] args)
        {

            var talltext = File.ReadAllLines("./Tall.txt");
            var tall = new List<Thingy>();


            foreach (var s in talltext)
            {
                if (s.ToCharArray()[0] == '0' && s.ToCharArray()[1] == 'b')
                {
                    tall.Add(ConvertFromBinary(s));
                }
                else if (char.IsLetter(s.ToCharArray()[0]))
                {
                    tall.Add(ConvertFromRoman(s));
                }
                else
                {
                    tall.Add(new Thingy
                    {
                        Tall = int.Parse(s),
                        Original = s
                    });
                }
            }

            var tall2 = tall.OrderByDescending(x => x.Tall);

 

            var pivot = (tall2.Count() / 2) + 1;

            var arr = tall2.ToArray();

            Console.WriteLine("Median = " + arr[pivot].Original);
            Console.WriteLine("Median = " + arr[pivot].Tall);
            Console.ReadLine();

        }

        private static Thingy ConvertFromRoman(string text)
        {
            int totalValue = 0, prevValue = 0;
            foreach (var c in text)
            {
                if (!_romanMap.ContainsKey(c))
                    return new Thingy
                    {
                        Original = text,
                        Tall = 0
                    };
                var crtValue = _romanMap[c];
                totalValue += crtValue;
                if (prevValue != 0 && prevValue < crtValue)
                {
                    if (prevValue == 1 && (crtValue == 5 || crtValue == 10)
                        || prevValue == 10 && (crtValue == 50 || crtValue == 100)
                        || prevValue == 100 && (crtValue == 500 || crtValue == 1000))
                        totalValue -= 2 * prevValue;
                    else
                        return new Thingy
                        {
                            Original = text,
                            Tall = 0
                        };
                }
                prevValue = crtValue;
            }
            return new Thingy
            {
                Tall = totalValue,
                Original = text
            };
        }

        private static Thingy ConvertFromBinary(string s)
        {
            var temp = s.Substring(2);

            return new Thingy
            {
                Tall = Convert.ToInt32(temp, 2),
                Original = s
            };
        }
    }

    public class Thingy
    {
        public int Tall { get; set; }
        public string Original { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luke5
{
    class Program
    {
        static void Main(string[] args)
        {
            var ord = File.ReadAllLines("./Ord.txt");

            var sum = ord.Where((t1, i) => ord.Where((t, j) => i != j).Any(t => SjekkOmAnagram(t1, t))).Count();

            Console.WriteLine("Fant {0} anagrammer", sum);

            Console.ReadLine();

        }

        private static bool SjekkOmAnagram(string s, string s1)
        {
            if (s.Length != s1.Length) return false;

            foreach (var c in s)
            {
                if (s1.Length == 0)
                {
                    return false;
                }
                if (s1.Contains(c))
                {
                    var ind = s1.IndexOf(c);
                    s1 = s1.Remove(ind, 1);
                }
                else
                {
                    return false;
                }
            }
            return s1.Length == 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luke10
{
    public class Program
    {
        static void Main(string[] args)
        {
            var tall = File.ReadAllLines("./Tall.txt");

            var liste = new List<Deal>();

            for (var i = 0; i < tall.Length; i++)
            {
                tall[i] = tall[i].Replace(".", ",");
            }

            for (var i = 0; i < tall.Length; i++)
            {
                for (var j = i; j < tall.Length; j++)
                {
                    var sum = decimal.Parse(tall[j]) - decimal.Parse(tall[i]);
                    if (sum > 0)
                    {
                        liste.Add(new Deal
                        {
                            Dag1 = i,
                            Dag2 = j,
                            Sum =sum
                        });
                    }
                }

            }
            Console.WriteLine("Antall = "+ liste.Count());
            Deal max = new Deal();
            foreach (var deal in liste)
            {
                if (deal.Sum > max.Sum)
                {
                    max = deal;
                }
            }

            Console.WriteLine(max);
            liste.Remove(max);
            Deal nestemax = new Deal();
            foreach (var deal in liste)
            {
                if (deal.Sum > nestemax.Sum)
                {
                    nestemax = deal;
                }
            }
            Console.WriteLine(nestemax);

            Console.WriteLine();
            Console.ReadLine();

        }

        public static bool Lovlig(Deal a, Deal b)
        {
            if (a.Dag2 > b.Dag1) return false;


            return true;
        }
    }

   


    public class Deal
    {
        public int Dag1 { get; set; }
        public int Dag2 { get; set; }
        public decimal Sum { get; set; }

        public override string ToString()
        {
            return $"{Dag1} - {Dag2} : {Sum}";
        }
    }
}

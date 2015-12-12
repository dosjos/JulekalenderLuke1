using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luke7
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            var sw = new Stopwatch();
            sw.Start();

            for (var i = 0; i < 1000; i++)
            {
                var subject = i;
                var factors = new List<int>();
                var maxFactor = 0;

                Console.WriteLine("Factoring {0} ...", subject);

               

                maxFactor = MaxFactor(subject, factors, maxFactor);
                if (factors.Contains(7))
                {
                    var factors2 = new List<int>();
                    var subject2 = PutMyInDonFlipItAndReverseIt(i);
                    var minFactor = MaxFactor(subject2, factors2, 0);
                    if (factors2.Contains(7))
                    {
                        sum += i;
                    }
                }

                var factorAnswer = 1L;
                factors.ForEach(f => factorAnswer *= f);

                Console.WriteLine("Factors: {0} = {1}",
                    string.Join(" * ",
                        factors.Select(j => j.ToString()).ToArray()),
                    factorAnswer);
                Console.WriteLine("Max Factor: {0}", maxFactor);
            }
            sw.Stop();

            Console.WriteLine("Summen er {0}", sum);
            
            Console.WriteLine("Elapsed Time: {0}ms", sw.ElapsedMilliseconds);
            Console.ReadLine();

            //var sum = 0;
            //for (var i = 7; i <=1000; i += 2)
            //{

            //    if (i%7 == 0 && PutMyInDonFlipItAndReverseIt(i) % 7 == 0)
            //    {
            //        sum += i;
            //    }
            //}
            //Console.WriteLine(sum);
            //Console.ReadLine();
        }

        private static int MaxFactor(int subject, List<int> factors, int maxFactor)
        {
            while (subject > 1)
            {
                var nextFactor = 2;
                if (subject%nextFactor > 0)
                {
                    nextFactor = 3;
                    do
                    {
                        if (subject%nextFactor == 0)
                        {
                            break;
                        }

                        nextFactor += 2;
                    } while (nextFactor < subject);
                }

                subject /= nextFactor;
                factors.Add(nextFactor);
                if (nextFactor > maxFactor)
                {
                    maxFactor = nextFactor;
                }
            }
            return maxFactor;
        }

        private static int PutMyInDonFlipItAndReverseIt(int i)
        {
            return int.Parse(new string(("" + i).Reverse().ToArray()));
        }
    }
}

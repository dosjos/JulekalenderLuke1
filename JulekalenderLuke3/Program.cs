using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JulekalenderLuke3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calendar al = new GregorianCalendar();
            var res = 0;
            for (int i = 1; i <= 2015; i++)
            {
                var date = new DateTime(i,1,1).AddDays(255);

                var day = date.DayOfWeek;

                if (day == DayOfWeek.Saturday)
                {
                    res++;
                }

                
            }

            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}

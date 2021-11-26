using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByndyusoftTestingTask
{
    class Programm
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            ArrayList arr = new ArrayList();
            for (int i = 0; i < 30; i++)
                arr.Add(rand.Next(-30, 30));
            try
            {
                double resSum = ArrayAnalysis.SumOfTwoMins(arr);
                Console.WriteLine("Anwer is " + resSum.ToString());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}

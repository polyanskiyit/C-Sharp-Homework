using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework__1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть першу оцiнку:");
            double fn = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть другу оцiнку:");
            double sn = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введiть третю оцiнку:");
            double tn = Convert.ToDouble(Console.ReadLine());

            AverageMark averageMark = new AverageMark();

            Console.WriteLine("Hello Git");


            Console.WriteLine("Середне число:");
            Console.WriteLine(
                averageMark.result(fn, sn, tn)
                );

            Console.ReadKey();
        }
    }
}

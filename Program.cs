using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("4Sin(x) * 5Cos(x)=" + Convert.ToString(4 * Math.Sin(x) * 5 *Math.Cos(x)));
            Console.ReadKey();
        }
    }
}

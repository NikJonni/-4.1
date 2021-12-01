using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число:  ");
            int N = Convert.ToInt32(Console.ReadLine());
            for (int n = 1; n <= N; n++)
            {
                int N1 = (n * 2) - 1;
                int sum = n * n;
                Console.WriteLine("Число n = {0} , сумма = {1}", N1, sum);
            }
            Console.ReadKey();
        }
    }
}

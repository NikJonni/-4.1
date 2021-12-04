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
            int sum = 0; ;
            for (int i = 1; i <= N; i++)
            {
                int n = (i * 2) - 1;
                sum = sum + n;
                Console.WriteLine("Нечетное число n = {0} , квадрат числа = {1}", n, sum);
            }
            Console.ReadKey();
        }
    }
}

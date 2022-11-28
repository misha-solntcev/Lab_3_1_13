using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 13. Дано число A(> 1). Вывести наименьшее из целых чисел K, 
    для которых сумма 1 + 1/2 + … + 1/K будет больше A, 
    и саму эту сумму. */

namespace Lab_3_1_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = 15;
            double K = 1;
            double sum = 1;
            while(sum < A)
            {                
                sum += 1 / K;
                K++;
                Console.WriteLine($"K = {K}, sum = {sum}");
            }
            Console.ReadKey();
        }
    }
}

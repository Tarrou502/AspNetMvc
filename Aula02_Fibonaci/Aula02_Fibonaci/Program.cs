using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02_Recursao{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i =0; i<=20;i++)
              Console.WriteLine("Fibonacci({0}) = {1}",i, Fibonacci(i));

            for (int i = 0; i <= 10; i++)
                Console.WriteLine("Fatorial({0}) = {1}", i, Fatorial(i));

            Console.ReadKey(); 
        }

        static int Fibonacci(int num)
        {
            if (num == 0)
                return 0;
            else if (num == 1)
                return 1;
            else
            {
                return Fibonacci(num - 1) + Fibonacci(num - 2);
            }
        }

        static int Fatorial(int num)
        {
            if (num == 0 || num == 1)
                return 1;
            else
            {
                return Fatorial(num - 1) * num;
            }
        }
    }
}

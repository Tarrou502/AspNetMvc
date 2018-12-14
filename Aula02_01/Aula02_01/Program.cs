using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula02_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Declare um array de tamanho 10 e preencha com os números de 10 a 19 utilizando um for
             */
            int[] array = new int[10];
            for (int i=0;i<10;i++)
            {
                int valor = 10 + i;
                array[i] = valor;
            }
            

            for (int i = 0; i < 10; i++)
            {

                array[i] += 1;
            }

            foreach (int num in array)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
           
        }
    }
}

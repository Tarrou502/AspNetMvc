using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaDeProgramacao
{
    class Program
    {
        // aula 1 Exercicio 1
        static void Main(string[] args)
        {
            
            double _soma = 0.0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite o " + (i + 1).ToString() + "º número:");
                _soma += Double.Parse(Console.ReadLine());
                
            }
            string _s;
            //_s = String.Format("A somatória é:{0:0.n2} ", _soma);
            _s = String.Format("A somatória é:{0:0.00} ", _soma);

            Console.WriteLine(_s);
            Console.ReadKey();
        }
    }
}

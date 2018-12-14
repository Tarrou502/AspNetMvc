using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03_Exerc01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculadora calc = new Calculadora();

            Console.WriteLine("Digite o primeiro número");
            var n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número");
            var n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("A soma é: "+  Calculadora.Soma(n1, n2));
            Console.ReadKey();
        }
    }

    public class Pessoa
    {
        public string Nome;
        public int Idade { get; set; }

        public void Comprimentar()
        {
            Console.WriteLine("Olá, eu sou " + Nome + " e tenho " + Idade + "anos");
        }


    }

    public static class Calculadora
    {
        public static double Soma(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Subtrai(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Multiplica(double num1, double num2)
        {
            return num1 * num2;
        }

        public static  double Divide(double num1, double num2)
        {
            double resultado = 0;
            try
            {
                resultado = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division of {0} by zero.", num2);
            }
            return resultado;


        }
    }
}

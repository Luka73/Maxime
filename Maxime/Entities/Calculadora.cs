using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxime.Entities
{
    public class Calculadora
    {
        public static double Soma(double n1, double n2)
        {
            return n1 + n2;
        }

        public static double Subtrai(double n1, double n2)
        {
            return n1 - n2;
        }

        public static double Mutiplica(double n1, double n2)
        {
            return n1 * n2;
        }

        public static double Divide(double n1, double n2)
        {
            if (n2 == 0)
            {
                Console.WriteLine("Não existe divisão por zero.");
                return 0;
            }

            return n1 / n2;
        }
        public static double porcentagem(double n, double p)
        {
            return (n * p) / 100;
        }
    }
}

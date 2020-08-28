using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxime.Entities
{
    public class Boleto
    {
        private string comprador;
        private double valor;
        private DateTime vencimeto;
        private const double TAXA = 2;
        private const int PRAZO = 5;

        public string Comprador { get => comprador; set => comprador = value; }
        public double Valor { get => valor; set => valor = value; }
        public DateTime Vencimeto { get => vencimeto; set => vencimeto = value; }

        public static double TAXA1 => TAXA;

        public static int PRAZO1 => PRAZO;
    }
}

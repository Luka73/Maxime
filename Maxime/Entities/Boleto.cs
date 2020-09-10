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
        private DateTime vencimento;
        private double taxa;
        private const int PRAZO = 5;

        public string Comprador { get => comprador.ToUpper(); set => comprador = value; }
        public double Valor { get => valor + taxa; set => valor = value; }
        public double Taxa { set => taxa = value; }

        public DateTime Vencimento() 
        {
            DateTime hoje = DateTime.Today;
            vencimento = hoje.AddDays(PRAZO);

            if (vencimento.DayOfWeek == DayOfWeek.Saturday) 
                vencimento.AddDays(2);
            else if (vencimento.DayOfWeek == DayOfWeek.Sunday) 
                vencimento.AddDays(1);
            
            return vencimento;
        } 

        public void AplicaDesconto(double desconto, bool porcentagem) // 10 (true, false)
        {
            if (porcentagem && desconto > 0)
            {
                desconto = Calculadora.porcentagem(valor, desconto);
            }

            valor = Calculadora.Subtrai(valor, desconto);
        }
    }
}

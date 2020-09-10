using Maxime.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxime
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto papel1 = new Produto();
            papel1.Codigo = "01";
            papel1.Modelo = "A4";
            papel1.Marca = "Canon";
            papel1.Valor = 10;
            papel1.ImpostoFederal = 2.1;
            papel1.ImpostoProvincial = 1.1;

            Produto papel2 = new Produto();
            papel2.Codigo = "02";
            papel2.Modelo = "A3";
            papel2.Marca = "HP";
            papel2.Valor = 15;
            papel2.ImpostoFederal = 3.2;
            papel2.ImpostoProvincial = 2.2;

            Produto papel3 = new Produto();
            papel3.Codigo = "03";
            papel3.Modelo = "A5";
            papel3.Marca = "OfficeJet";
            papel3.Valor = 11;
            papel3.ImpostoFederal = 1.3;
            papel3.ImpostoProvincial = 1.0;

            Registradora registradora = new Registradora();
            registradora.AddProduto(papel1);
            registradora.AddProduto(papel2);
            registradora.AddProduto(papel3);

            Console.WriteLine("Produto 1: " + registradora.GetNomeDoProduto(papel1) + " - " + papel1.Preco);
            Console.WriteLine("Produto 2: " + registradora.GetNomeDoProduto(papel2) + " - " + papel2.Preco);
            Console.WriteLine("Produto 3: " + registradora.GetNomeDoProduto(papel3) + " - " + papel3.Preco);
            Console.WriteLine("Total a pagar: {0:0.00} ", registradora.GetTotal());

            Boleto boleto = new Boleto();
            boleto.Comprador = "Luana Fernandes";
            boleto.Valor = registradora.GetTotal();
            boleto.Taxa = 3.2;
            boleto.AplicaDesconto(8, false);

            Console.WriteLine("Vencimento: " + boleto.Vencimento());
            Console.WriteLine("Comprador: " + boleto.Comprador);
            Console.WriteLine("Valor do boleto: " + boleto.Valor);

            Console.ReadKey();
        }
    }
}

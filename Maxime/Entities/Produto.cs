using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxime.Entities
{
    public class Produto
    {
        private string codigo;
        private string modelo;
        private string marca;
        private double impostoFederal;
        private double valor;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public string Marca { get => marca; set => marca = value; }
        public double ImpostoFederal { get => impostoFederal; set => impostoFederal = value; }
        public double Valor { get => valor; set => valor = value; }
    }
}

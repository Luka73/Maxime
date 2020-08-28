using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxime.Entities
{
    public class Registradora
    {
        private double total;

        public void addProduto(Produto produto)
        {
            total = total + produto.Valor + produto.ImpostoFederal;
        }

        public double getTotal()
        {
            return total;
        }

        public string getNomeDoProduto(Produto produto)
        {
            //código/modelo – marca
            return produto.Codigo + "/" + produto.Modelo + " - " + produto.Marca;
        }
    }
}

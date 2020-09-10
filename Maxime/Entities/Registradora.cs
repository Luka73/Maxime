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

        public void AddProduto(Produto produto)
        {
            total = total + produto.Preco;
        }

        public double GetTotal()
        {
            return total;
        }

        public string GetNomeDoProduto(Produto produto)
        {
            //código/modelo – marca
            return produto.Codigo + "/" + produto.Modelo + " - " + produto.Marca;
        }
    }
}

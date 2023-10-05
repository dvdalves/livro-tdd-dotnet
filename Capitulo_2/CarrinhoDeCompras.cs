using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo_2
{
    public class CarrinhoDeCompras
    {
        public List<Produto> Produtos { get; set; }

        public CarrinhoDeCompras()
        {
            Produtos = new List<Produto>();
        }

        public void Adiciona(Produto produto)
        {
            Produtos.Add(produto);
        }
    }
}

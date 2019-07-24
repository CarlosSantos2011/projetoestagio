using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLoja2.Models
{
    public class CompraItem
    {
        public Compra Compra { get;  set; }
<<<<<<< HEAD
        public Produto Produtos { get;  set; }
=======
        public Produtos Produtos { get;  set; }
>>>>>>> 30866b005970f756765ff9136656d50e9d9573a5
        public double DescontoPorItem { get;  set; }
        public int Quantidade { get;  set; }
        public float ValorUnitario { get;  set; }
        public double ValorTotal { get;  set; }

<<<<<<< HEAD
        public CompraItem(Compra compra, Produto produtos, int quantidade, float valorUnitario, double valorTotal)
=======
        public CompraItem(Compra compra, Produtos produtos, int quantidade, float valorUnitario, double valorTotal)
>>>>>>> 30866b005970f756765ff9136656d50e9d9573a5
        {
            compra = Compra;
            produtos = Produtos;
            quantidade = Quantidade;
            valorUnitario = ValorUnitario;
            valorTotal = ValorTotal;
        }
    }
}
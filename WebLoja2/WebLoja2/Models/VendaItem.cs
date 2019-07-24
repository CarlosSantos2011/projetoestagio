using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLoja2.Models
{
    public class VendaItem
    {
        public double ValorTotal { get;  set; }
        public int Quantidade { get;  set; }
        public Venda Venda { get;  set; }
<<<<<<< HEAD
        public Produto Produto { get;  set; }
        public float ValorUnitario { get;  set; }
        public float DescontoPorItem { get;  set; }

        public VendaItem(Venda venda, Produto produto, int quantidade, double valorTotal, float valorUnitario)
=======
        public Produtos Produto { get;  set; }
        public float ValorUnitario { get;  set; }
        public float DescontoPorItem { get;  set; }

        public VendaItem(Venda venda, Produtos produto, int quantidade, double valorTotal, float valorUnitario)
>>>>>>> 30866b005970f756765ff9136656d50e9d9573a5
        {
            Venda = venda;
            Produto = produto;
            Quantidade = quantidade;
            ValorTotal = valorTotal;
            ValorUnitario = ValorUnitario;

        }
    }
}
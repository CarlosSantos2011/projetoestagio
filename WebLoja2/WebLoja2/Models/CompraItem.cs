﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLoja2.Models
{
    public class CompraItem
    {
        public Compra Compra { get;  set; }
        public Produtos Produtos { get;  set; }
        public double DescontoPorItem { get;  set; }
        public int Quantidade { get;  set; }
        public float ValorUnitario { get;  set; }
        public double ValorTotal { get;  set; }

        public CompraItem(Compra compra, Produtos produtos, int quantidade, float valorUnitario, double valorTotal)
        {
            compra = Compra;
            produtos = Produtos;
            quantidade = Quantidade;
            valorUnitario = ValorUnitario;
            valorTotal = ValorTotal;
        }
    }
}
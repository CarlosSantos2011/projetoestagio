using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lojaweb
{
    public class Estoque
    {
        public Produtos Produtos { get; private set; }
        public Compra Compra { get; private set; }
        public Venda Venda { get; private set; }
        public int Saida { get; private set; }
        public int Entrada { get; private set; }
        public bool Garantia { get; private set; }
        public string TipoMovimentacao { get; private set; }

        public Estoque(Produtos produto, Compra compra, Venda venda, int saida, int entrada, bool garantia, string tipoMovimentacao)

        {
            produto = Produtos;
            compra = Compra;
            saida = Saida;
            entrada = Entrada;
            venda = Venda;
            garantia = Garantia;
            tipoMovimentacao = TipoMovimentacao;
        }


        public static bool LancarEstoque(Venda venda)
        {
            foreach(var item in Venda.itens)
            {
                Estoque x = new Estoque();
                x.Produtos = item.Produto.Handle;
                x.Saida = item.Produto.Quantidade;
                x.Venda = item.Venda;
                x.save()
            }           

        }

        public static bool EstornarEstoque()
        {

        }

    }
}
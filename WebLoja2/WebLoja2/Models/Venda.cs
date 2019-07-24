﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLoja2.Models
{
    public class Venda
    {
        public int Id { get;  set; }
        public DateTime Data { get;  set; }
        public string FormaDePagamento { get;  set; }
        public double Desconto { get;  set; }
        public Clientes Cliente { get; set; }
        public Funcionario Funcionario { get;  set; }
        public double Valor { get;  set; }
        public Venda(int id, DateTime data, string formaDePagamento, Clientes cliente, Funcionario funcionario, double valor)
        {
            id = Id;
            data = Data;
            formaDePagamento = FormaDePagamento;
            cliente = Cliente;
            funcionario = Funcionario;
            valor = Valor;

        }

    }
}
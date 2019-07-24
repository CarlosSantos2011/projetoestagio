﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLoja2.Models
{
    public class Compra
    {
        public int Id { get;  set; }
        public string Observacoes { get;  set; }
        public Fornecedor Fornecedor { get;  set; }
        public DateTime Data { get;  set; }
        public double Valor { get;  set; }
        public Funcionario Funcionario { get; set; }

        public Compra(int id, Fornecedor fornecedor, Funcionario funcionario, DateTime data, double valor)
        {
            Id = id;
            Fornecedor = fornecedor;
            Funcionario = funcionario;
            Valor = valor;
            Data = data;

        }
    }
}
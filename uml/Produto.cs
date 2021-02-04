using System;
using System.Collections.Generic;
using System.Text;

namespace uml
{
        abstract class Produto
        {
            String nome;
            double preco;
            int qtd;

        public static object Livro { get; internal set; }
        public string Nome { get => nome; set => nome = value; }
            public double Preco { get => preco; set => preco = value; }
            public int Qtd { get => qtd; set => qtd = value; }

            public abstract double calculaImposto();
        }
    }
}

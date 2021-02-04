using System;
using System.Collections.Generic;
using System.Text;

namespace uml
{
        class Livro : Produto
        {
            String Autor;
            String Tema;
            int qtdPag;

            public override double calculaImposto()
            {
                if (Tema == "educativo")
                    return 0;
                else
                    return Preco * 0.10;
            }
        }
    }

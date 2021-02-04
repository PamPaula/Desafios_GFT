using System;
using System.Collections.Generic;
using System.Text;

namespace uml
{
    class Livro
    {
        public Produto Livros { get; set; } 
        public string Autor { get; set; }
        public string Tema { get; set; }
        public int QtdPag { get; set; }
    }
}

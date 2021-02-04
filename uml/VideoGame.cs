using System;
using System.Collections.Generic;
using System.Text;

namespace uml
{
    class VideoGame : Produto
    {
        String Marca;
        String Modelo;
        bool isUsado;

        public override double calculaImposto()
        {
            if (isUsado)
                return Preco * 0.25;
            else
                return Preco * 0.45;
        }
    }
}

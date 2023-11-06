using System;
using XADREZ.tabuleiro;

namespace XADREZ.xadrez
{
    internal class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) 
        {
        }

        public override string ToString()
        {
            return "R";
        }

    }
}

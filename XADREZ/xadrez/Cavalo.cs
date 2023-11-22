using System;
using XADREZ.tabuleiro;

namespace XADREZ.xadrez
{
    internal class Cavalo : Peca
    {

        public Cavalo(Tabuleiro tab, Cor cor) : base(tab, cor)
        {
        }

        public override string ToString()
        {
            return "C";
        }

        private bool PodeMoverCavalo(Posicao pos)
        {
            Peca p = Tab.Peca(pos);

            return p == null || p.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveisPeca()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];

            Posicao pos = new Posicao(0, 0);


            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 2);               
            if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.DefinirValores(Posicao.Linha - 2, Posicao.Coluna - 1);
            if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.DefinirValores(Posicao.Linha - 2, Posicao.Coluna + 1);
            if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 2);
            if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 2);
            if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
            {
                mat[pos.Linha, pos.Coluna] = true;
            }


            pos.DefinirValores(Posicao.Linha + 2, Posicao.Coluna + 1);
            if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
            {
                mat[pos.Linha, pos.Coluna] = true;
            }


            pos.DefinirValores(Posicao.Linha + 2, Posicao.Coluna - 1);
            if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 2);
            if (Tab.Peca(pos) != null && Tab.Peca(pos).Cor != Cor)
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            return mat;
        }
    }
}

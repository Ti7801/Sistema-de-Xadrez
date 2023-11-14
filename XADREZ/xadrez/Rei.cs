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

        private bool PodeMoverRei(Posicao pos)
        {
            Peca p = Tab.Peca(pos);

            return p == null || p.Cor != Cor;
        }

        public override bool[,] MovimentosPossiveisPeca()
        {
            bool[,] mat = new bool[Tab.Linhas, Tab.Colunas];
            Posicao pos = new Posicao(0, 0);

            // acima
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna);
            if (Tab.PosicaoValida(pos) && PodeMoverRei(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            // nordeste
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMoverRei(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            // direita
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMoverRei(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            // sudeste
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna + 1);
            if (Tab.PosicaoValida(pos) && PodeMoverRei(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //abaixo 
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna);
            if (Tab.PosicaoValida(pos) && PodeMoverRei(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //sudoeste
            pos.DefinirValores(Posicao.Linha + 1, Posicao.Coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMoverRei(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //Esquerda
            pos.DefinirValores(Posicao.Linha, Posicao.Coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMoverRei(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //Noroeste
            pos.DefinirValores(Posicao.Linha - 1, Posicao.Coluna - 1);
            if (Tab.PosicaoValida(pos) && PodeMoverRei(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }

            return mat;
        }

    }
}

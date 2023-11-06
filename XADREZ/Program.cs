using System;
using XADREZ.tabuleiro;
using XADREZ.xadrez;

namespace XADREZ
{
    class Program
    {
        static void Main(string[] args)
        {
            // CAMADA DE APLICAÇÃO  
            // CAMADA JOGO DE XADREZ
            // CAMADA TABULEIRO

            Tabuleiro tab = new Tabuleiro(8, 8);

            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

            Tela.ImprimirTabuleiro(tab);

            Console.ReadLine() ;    
          




        }
    }
}

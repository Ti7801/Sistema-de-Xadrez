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

            /*       
            Console.ReadLine() ;          
            PosicaoXadrez pos = new PosicaoXadrez('c', 7);
            Console.WriteLine(pos);
            Console.WriteLine(pos.toPosicao());
            */
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));
                tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(3, 5));

                Tela.ImprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

        }
    }
}

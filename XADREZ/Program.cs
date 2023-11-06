using System;
using XADREZ.tabuleiro;

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
            Posicao P;

            P = new Posicao(3, 4);

            Console.WriteLine("Posição: " + P);
            Console.ReadLine();
            */

            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.ImprimirTabuleiro(tab);

            Console.ReadLine() ;    
          




        }
    }
}

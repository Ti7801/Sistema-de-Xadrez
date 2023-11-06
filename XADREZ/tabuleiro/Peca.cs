
namespace XADREZ.tabuleiro
{
    internal class Peca
    {
        //PROTECTED : Ela pode ser acessada por ela mesmo e pelas subClasses dela.

        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; } 
        public int QteMovimentos { get; protected set; }    
        public Tabuleiro Tab { get; protected set; }

        public Peca(Posicao posicao, Tabuleiro tab, Cor cor) 
        {
            Posicao = posicao; 
            Tab= tab;   
            Cor = cor;
            QteMovimentos = 0; // No início do jogo a peca tem zero movimentos.
        }

    }
}

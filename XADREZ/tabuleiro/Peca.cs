
namespace XADREZ.tabuleiro
{
    internal abstract class Peca
    {
        //PROTECTED : Ela pode ser acessada por ela mesmo e pelas subClasses dela.

        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; } 
        public int QteMovimentos { get; protected set; }    
        public Tabuleiro Tab { get; protected set; }

        public Peca(Tabuleiro tab, Cor cor) 
        {
            Posicao = null; 
            Tab= tab;   
            Cor = cor;
            QteMovimentos = 0; // No início do jogo a peca tem zero movimentos.
        }

        public void IncrementarQteMovimentos()
        {
            QteMovimentos++;
        }

        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveisPeca();

            for (int i =0; i < Tab.Linhas;i++)
            {
                for (int j =0; j < Tab.Colunas; j++)
                {
                    if (mat[i, j] == true)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool PodeMoverPara(Posicao pos)
        {
            return MovimentosPossiveisPeca()[pos.Linha, pos.Coluna];
        }

        public abstract bool[,] MovimentosPossiveisPeca();


    }
}

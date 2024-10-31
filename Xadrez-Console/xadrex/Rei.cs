
using tabuleiro;

namespace xadrex
{
    internal class Rei : Peca
    {
        public Rei(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
        }

        private bool PodeMover(Posicao pos)
        {
            Peca p = tab.peca(pos);
            return p == null || p.cor != cor; 
        }

        public override bool[,] movimentosPossiveis()
        {
            bool[,] mat = new bool[ tab.Linha, tab.Coluna ];
            Posicao pos =new Posicao (0,0);

            //acima
            pos.DefinirValores(posicao.Linha - 1, posicao.Coluna);
            if (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha,pos.Coluna] = true;
            }
            //nordeste
            pos.DefinirValores(posicao.Linha - 1, posicao.Coluna + 1);
            if (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //direita
            pos.DefinirValores(posicao.Linha , posicao.Coluna + 1);
            if (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //suldeste
            pos.DefinirValores(posicao.Linha + 1, posicao.Coluna + 1);
            if (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //abaixo
            pos.DefinirValores(posicao.Linha - 1, posicao.Coluna );
            if (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //suldoeste
            pos.DefinirValores(posicao.Linha + 1, posicao.Coluna - 1);
            if (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //esquerda
            pos.DefinirValores(posicao.Linha , posicao.Coluna - 1);
            if (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            //noroeste
            pos.DefinirValores(posicao.Linha - 1, posicao.Coluna - 1);
            if (tab.posicaoValida(pos) && PodeMover(pos))
            {
                mat[pos.Linha, pos.Coluna] = true;
            }
            return mat;
        }

        public override string ToString()
        {
            return "R";
        }
    }
}

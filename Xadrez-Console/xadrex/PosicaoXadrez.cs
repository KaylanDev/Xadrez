﻿

using tabuleiro;

namespace xadrex
{
    internal class PosicaoXadrez
    {
        public char Coluna { get; private set; }
        public int Linha { get; private set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;
        }
        public Posicao ToPosicao() {
            return new Posicao(8 -Linha , Coluna - 'a');
        }

        public override string ToString()
        {
            return " " + Coluna + Linha;
        }
    }
}

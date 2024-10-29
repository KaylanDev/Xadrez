using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    internal class Tabuleiro
    {
        public int Linha { get; set; }
        public int Colunas { get; set; }
        public Peca[,] pecas { get; private set; }

        public Tabuleiro() { }
        public Tabuleiro(int linha, int colunas)
        {
            Linha = linha;
            Colunas = colunas;
            pecas = new Peca[linha,colunas];
        }

        public void ColocarPeca(Peca p, Posicao pos)
        {
            pecas[pos.Linha, pos.Coluna] = p;
            p.posicao = pos;
        }
    }
}

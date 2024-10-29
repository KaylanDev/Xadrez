using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xadrez_Console.tabuleiro;

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
            pecas = new Peca[linha, colunas];
        }

        public Peca peca(Posicao pos)
        {
            return pecas[pos.Linha, pos.Coluna];
        }
        public void ColocarPeca(Peca p, Posicao pos)
        {
            if (existirPeca(pos))
            {
                throw new TabuleiroExeption("Ja existe uma peça nessa posição!");
            }   
            pecas[pos.Linha, pos.Coluna] = p;
            p.posicao = pos;
        }

        public bool existirPeca(Posicao pos)
        {
            validadePosicao(pos);
            return peca(pos) != null;
        }

        public bool posicaoValida(Posicao pos)
        {
            if (pos.Linha < 0 || pos.Linha >= Linha || pos.Coluna < 0 || pos.Coluna >= Colunas)
            {
                return false;
            }


            return true;

        }

        public void validadePosicao(Posicao pos)
        {
            if (!posicaoValida(pos)) {
                throw new TabuleiroExeption("Posição Invalida!");
            }
        }

    }
}

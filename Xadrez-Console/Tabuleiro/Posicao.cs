using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    internal class Posicao
    {
        public Posicao()
        {
        }

        public int Linha { get;  set; }
        public int Coluna { get;  set; }

        public Posicao(int linha, int coluna)
        {
            Linha = linha;
            Coluna = coluna;
        }

        public void DefinirValores(int linha,int coluna)
        {
                Linha = linha;
                Coluna = coluna;
        }

        public override string ToString()
        {
            return $"{Linha} {Coluna}";
        }


    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;

namespace  tabuleiro
{
    abstract class Peca
    {
        public Posicao posicao { get;  set; }
        public Cor cor { get; protected set; }
        public int qnteMovimento { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca( Cor cor, Tabuleiro tab)
        {
            this.posicao = null;
            this.cor = cor;
            this.qnteMovimento = 0;
            this.tab = tab;
        }
        public abstract bool[,] movimentosPossiveis();

        public void IncrementarQntDeMovimentos()
        {
            qnteMovimento++;
        }
    }
}

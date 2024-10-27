﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tabuleiro;

namespace Xadrez_Console.Tabuleiro
{
    internal class Peca
    {
        public Posicao posicao { get;  set; }
        public Cor cor { get; protected set; }
        public int qnteMovimento { get; protected set; }
        public Tabuleiro tab { get; protected set; }

        public Peca(Posicao posicao, Cor cor, Tabuleiro tab)
        {
            this.posicao = posicao;
            this.cor = cor;
            this.qnteMovimento = 0;
            this.tab = tab;
        }
    }
}
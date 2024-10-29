﻿using tabuleiro;
using Xadrez_Console;
using xadrex;

Tabuleiro tab = new Tabuleiro(8,8);
tab.ColocarPeca(new Torre(Cor.Preta,tab), new Posicao(0, 0));
tab.ColocarPeca(new Torre(Cor.Preta,tab), new Posicao(1, 3));
tab.ColocarPeca(new Rei(Cor.Preta,tab), new Posicao(2, 4));
Tela.ImprimirTabuleiro(tab);

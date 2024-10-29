using tabuleiro;
using Xadrez_Console;
using xadrex;
using Xadrez_Console.tabuleiro;

try
{

    Tabuleiro tab = new Tabuleiro(8, 8);
    tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(0, 0));
    tab.ColocarPeca(new Torre(Cor.Preta, tab), new Posicao(1, 3));
    tab.ColocarPeca(new Rei(Cor.Preta, tab), new Posicao(2, 4));

    tab.ColocarPeca(new Rei(Cor.Branca, tab), new Posicao(3, 5));
    Tela.ImprimirTabuleiro(tab);
}catch(TabuleiroExeption e)
{
    Console.WriteLine(e.Message);
}

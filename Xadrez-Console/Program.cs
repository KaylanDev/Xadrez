using tabuleiro;
using Xadrez_Console;
using xadrex;
using Xadrez_Console.tabuleiro;

try
{
    PartidaDeXadrez partida = new PartidaDeXadrez();
    while (!partida.Terminada)
    {
        Console.Clear();
        Tela.ImprimirTabuleiro(partida._tab);
        Console.WriteLine();
        Console.Write("Origem: ");
       Posicao origem = Tela.LerPosicaXadrex().ToPosicao();
        Console.WriteLine("Destino: ");
        Posicao destino = Tela.LerPosicaXadrex().ToPosicao();

        partida.ExecutarMovimento(origem, destino);
    }
}
catch(TabuleiroExeption e)
{
    Console.WriteLine(e.Message);
}

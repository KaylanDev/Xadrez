


using tabuleiro;

namespace Xadrez_Console
{
    internal class Tela
    {
        public Tela()
        {
        }

        public  static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linha; i++)
            {
                for (int j = 0; j < tab.Colunas; j++)
                {
                    if (tab.pecas[i, j] == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(tab.pecas[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
        }

    }
}


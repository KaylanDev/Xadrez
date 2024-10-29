using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Xadrez_Console.tabuleiro
{
    internal class TabuleiroExeption : Exception
    {
        public TabuleiroExeption(string msg) : base(msg) {
        
        }
    }
}

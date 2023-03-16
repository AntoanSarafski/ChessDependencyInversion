using ChessDependencyInversion;
using System;

namespace DependecyInversionRealExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ChessEngine chess = new ChessEngine();

            chess.Start();
        }
    }
}

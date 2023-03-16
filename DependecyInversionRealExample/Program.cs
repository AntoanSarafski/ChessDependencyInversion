using ChessDependencyInversion;
using ChessDependencyInversion.Renderers;
using System;

namespace DependecyInversionRealExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            ChessEngine chess = new ChessEngine(new ConsoleRenderer());

            chess.Start();
        }
    }
}

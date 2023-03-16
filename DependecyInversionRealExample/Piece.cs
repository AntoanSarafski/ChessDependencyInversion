using ChessDependencyInversion.Renderers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChessDependencyInversion
{
    public class Piece
    {

        public Piece(char symbol)
        {
            Symbol = symbol;
        }

        public char Symbol { get; set; }


        public void Draw(IRenderer renderer)
        {
            renderer.Write(Symbol);
        }
    }
}

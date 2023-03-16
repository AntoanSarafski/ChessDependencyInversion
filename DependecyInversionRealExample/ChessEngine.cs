using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ChessDependencyInversion
{
    public class ChessEngine
    {
        private List<Piece> whitePieces;
        private List<Piece> blackPieces;

        public ChessEngine()
        {
            whitePieces = new List<Piece>()
            {
                new Piece('R'),
                new Piece('k'),
                new Piece('B'),
                new Piece('Q'),
                new Piece('K'),
                new Piece('B'),
                new Piece('k'),
                new Piece('R'),
            };
            for (int i = 0; i < 8; i++)
            {
                whitePieces.Add(new Piece('P'));
            }

            blackPieces = new List<Piece>()
            {
                new Piece('R'),
                new Piece('k'),
                new Piece('B'),
                new Piece('Q'),
                new Piece('K'),
                new Piece('B'),
                new Piece('k'),
                new Piece('R'),
            };
            for (int i = 0; i < 8; i++)
            {
                blackPieces.Add(new Piece('P'));
            }

        }
        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Chess board");
                Console.WriteLine("White pieces:");
                foreach (var piece in whitePieces)
                {
                    piece.Draw();
                }
                Console.WriteLine();
                Console.WriteLine("Black pieces:");
                foreach (var piece in blackPieces)
                {
                    piece.Draw();
                }
                Thread.Sleep(1000);

                Console.Clear();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ChessDependencyInversion
{
    public class ChessEngine
    {
        public void Start()
        {
            while (true)
            {
                Console.WriteLine("Drawing board");
                Thread.Sleep(1000);

                Console.Clear();
            }
        }
    }
}

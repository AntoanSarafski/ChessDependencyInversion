using System;
using System.Collections.Generic;
using System.Text;

namespace ChessDependencyInversion.Renderers
{
    public class ConsoleRenderer : IRenderer
    {
        public void Clear()
        {
            Console.Clear();
        }

        public void Write(object msg)
        {
            Console.Write(msg);
        }

        public void WriteLine(object msg)
        {
            Console.WriteLine(msg);
        }
    }
}

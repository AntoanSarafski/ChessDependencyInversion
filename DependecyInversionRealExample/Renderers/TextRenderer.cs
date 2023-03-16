using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ChessDependencyInversion.Renderers
{
    public class TextRenderer : IRenderer
    {
        private string path = "../../../chess.txt";

        public void Clear()
        {
            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.Write("");
            }
        }

        public void Write(object msg)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.Write(msg);
            }
        }

        public void WriteLine(object msg)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(msg);
            }
        }
    }
}

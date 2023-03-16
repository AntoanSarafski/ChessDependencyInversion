using System;
using System.Collections.Generic;
using System.Text;

namespace ChessDependencyInversion.Renderers
{
    public interface IRenderer
    {
        void Write(object msg);

        void WriteLine(object msg);

        void Clear();

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    public interface ICompression
    {
        void compressFolder(string Compressfoldername);
    }
}

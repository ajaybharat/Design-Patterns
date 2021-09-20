using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    class ZipCompression : ICompression
    {
        public void compressFolder(string Compressfoldername)
        {
            Console.WriteLine("Folder is compressed using rar approach: '" + Compressfoldername + ".rar' file is created");
        }
    }
}

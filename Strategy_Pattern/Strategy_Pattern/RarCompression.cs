using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    class RarCompression : ICompression
    {
        public void compressFolder(string Compressfoldername)
        {
            Console.WriteLine("Folder is compressed using Zip approach: '" + Compressfoldername + ".zip' file is created");
        }
    }
}

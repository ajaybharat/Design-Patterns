using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    public class CompressionContext
    {
        private ICompression Compression;

        public CompressionContext(ICompression Compression)
        {
            this.Compression = Compression;
        }

        public void setStrategy(ICompression Compression)
        {
            this.Compression = Compression;
        }

        public void CreateArchive(string compressedArchievefoldername)
        {
            Compression.compressFolder(compressedArchievefoldername);
        }
    }
}

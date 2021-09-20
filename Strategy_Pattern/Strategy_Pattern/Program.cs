using System;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CompressionContext ctx = new CompressionContext(new ZipCompression());
            ctx.CreateArchive("dotnetDesignpatterns");
            ctx.setStrategy(new RarCompression());
            ctx.CreateArchive("dotnetDesignpatterns");
        }
    }
}

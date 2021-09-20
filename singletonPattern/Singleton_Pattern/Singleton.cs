using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Pattern
{
    public sealed class Singleton
    {
        private static int count = 0;
        private static readonly object instancelock = new object();
        private static Singleton instance = null;
        public static Singleton getInstance()
        {
            if(instance == null)
            {
                lock(instancelock)
                {
                    if (instance == null)
                        instance = new Singleton();
                }
            }
            return instance;
        }
        private Singleton()
        {
            count++;
            Console.WriteLine("counter value: " + count.ToString());
        }

        public void printFromInstance(string message)
        {
            Console.WriteLine(message);
        }
    }
}

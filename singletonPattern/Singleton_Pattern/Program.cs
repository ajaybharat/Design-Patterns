using System;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => Printteacherinstance(),
                () => Printstudentinstance()
                );
            Console.ReadLine();
        }

        private static void Printteacherinstance()
        {
            Singleton inst1 = Singleton.getInstance();
            inst1.printFromInstance("from inst1");
        }
        private static void Printstudentinstance()
        {
            Singleton inst2 = Singleton.getInstance();
            inst2.printFromInstance("from inst2");
        }
    }
}

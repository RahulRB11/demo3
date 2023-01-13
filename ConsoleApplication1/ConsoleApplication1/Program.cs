using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(7,8));
            Console.WriteLine(Diff(5,1));
            Console.WriteLine(Prod(2,8));
        }
        public static int Add(int a, int b)
        {
            return (a + b);
        }
        public static int Diff(int a, int b)
        {
            return (a - b);
        }
        public static int Prod(int a, int b)
        {
            return (a * b);
        }
    }
}

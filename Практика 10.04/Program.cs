using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1 t1 = new Task1("Hello");
            Console.WriteLine(t1.Output);
            t1.Review();
            Console.WriteLine(t1.Output);

            Console.WriteLine(t1.ToString());
        }
    }
}

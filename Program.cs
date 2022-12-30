using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {

            UC1 uc1 = new UC1();
            int result = uc1.Findmax(1, 2, 3);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

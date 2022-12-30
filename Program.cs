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

            //for UC1
            //int result = uc1.Findmax(1, 2, 3);

            //for UC1.1
            //int result = uc1.Findmax(33, 1, 2);

            //for UC1.2
            int result = uc1.Findmax(1,33, 2);
            Console.WriteLine("Maximum number is : " + result);
            Console.ReadLine();
        }
    }
}

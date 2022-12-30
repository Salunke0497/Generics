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
            //Console.WriteLine("Maximum number is : " + result);

            //for UC1.1
            //int result = uc1.Findmax(33, 1, 2);
            //Console.WriteLine("Maximum number is : " + result);

            //for UC1.2
            //int result = uc1.Findmax(1,33, 2);
            //Console.WriteLine("Maximum number is : " + result);

            //FOR UC1.3
            //int result = uc1.Findmax(1, 2, 33);
            //Console.WriteLine("Maximum number is : " + result);

            // UC2
            //float result = uc1.Findmax(1f, 2f, 33f);
            //Console.WriteLine("Maximum number is : " + result);

            //UC2.1
            //float result = uc1.Findmax(33f, 2f, 3f);
            //Console.WriteLine("Maximum number is : " + result);

            //UC2.2 find max at 2nd position
            float result = uc1.Findmax(1f, 33f, 2f);
            Console.WriteLine("Maximum number is : " + result);
            Console.ReadLine();
        }
    }
}

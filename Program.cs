using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)

        {

            //UC1 uc1 = new UC1();

            //for UC1
            //int result = uc1.Findmax(1, 2, 3);
            //Console.WriteLine("Maximum number is : " + result);

            //for UC1.1 find max at 1st postion
            //int result = uc1.Findmax(33, 1, 2);
            //Console.WriteLine("Maximum number is : " + result);

            //for UC1.2 find max at 2nd postion
            //int result = uc1.Findmax(1,33, 2);
            //Console.WriteLine("Maximum number is : " + result);

            //FOR UC1.3 find max at 3rd postion
            //int result = uc1.Findmax(1, 2, 33);
            //Console.WriteLine("Maximum number is : " + result);



            // UC2
            //float result = uc1.Findmax(1f, 2f, 33f);
            //Console.WriteLine("Maximum number is : " + result);

            //UC2.1 find max at 1st postion
            //float result = uc1.Findmax(33f, 2f, 3f);
            //Console.WriteLine("Maximum number is : " + result);

            //UC2.2 find max at 2nd position
            //float result = uc1.Findmax(1f, 33f, 2f);
            //Console.WriteLine("Maximum number is : " + result);

            //UC2.3 find max at 3rd position
            //float result = uc1.Findmax(1f, 2f, 33f);
            //Console.WriteLine("Maximum number is : " + result);


            //string result = uc1.Findmax("Aaa", "ccc", "xxx");
            //Console.WriteLine("Maximum string is : " + result);
            //Console.ReadLine();

            Generics<int> generics = new Generics<int>(30, 30, 50);
            int result = generics.Genmethod(20, 50, 30);
            Console.WriteLine("Maximum string is : " + result);
            Console.ReadLine();

        }
    }
}

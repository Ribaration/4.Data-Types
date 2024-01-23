using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaration

            string name ="Adam";
            int age = 35;
            bool isTall = false;
            double weight = 80.2;

            /*for the smallest least precise deimal we use float
             * for more precise use decimal for money
             * In most cases double wil do just fine
             */

            Console.WriteLine(name + " is " + age + " he weighs " + weight);
            Console.WriteLine(" it is " + isTall + " that he is tall.");

            //Freeze console

            Console.ReadLine();


        }
    }
}

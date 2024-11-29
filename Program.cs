using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
    // Basically namespace is a container, where we can execute our code
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Data type in C#:
              Integer: int   --> 4bytes
                   * Long: long --> 8bytes
                   * Double: double  --> 8bytes
                   * Float: float   --> 4bytes
              Character: char --> 2bytes
              Boolean: bool   --> 1bit
              String: str     --> 2bytes/character
             */


            //string imp = Console.ReadLine();
            //Console.WriteLine(imp);
            //Console.Read();

            /* Basically, Console.ReadLine waiting for User input on cosole then it intialize the value in variable imp*/

            //float a = 34.7F; // We need to write F in last of the value 
            //double b = 256.54D;  //Incase of double, it's not mandatory to use D in last, bucause double is default 
            //int c = 20;
            //bool isGreat = true;

            //Console.WriteLine(c);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(isGreat);



            // Type Casting: converting of one data type to another is called Type Casting

            /*Ther are two type of Type Casting, following Are:
                1.) Implicit Casting: char --> int --> long --> float --> double  {--> means to}
                2.) Explicit Casting: 
             */

            // Example of Explicit Casting
            // int x1 = (int)3.5;
            // Console.WriteLine(x1);

            // Example of Implicit Casting
            // int x2 = 5;
            // float y = x2;
            // double x3 = y;
            // Console.WriteLine(x3);


            //Console.WriteLine("Enter your name:");
            //String name = Console.ReadLine();
            //Console.WriteLine("Hey " + name);

            //Console.WriteLine("How many candies u want:");
            //String c = Console.ReadLine();
            //Console.WriteLine("You will get 4 more candies:" +
            //    (Convert.ToInt32(c) + 4));


            /* Opertaor in C# 
             * 1.) Airthmetic Operator
             * 2.) Assignment Operator
             * 3.) Logical Operator
             * 4.) Comparison Operator
             */


            //int a = 4;
            //int b = 5;
            //Console.WriteLine("Sum of A + B = " + (a + b));
            //Console.WriteLine("Sum of A - B = " + (a - b));
            //Console.WriteLine("Sum of A * B = " + (a * b));
            //Console.WriteLine("Sum of A / B = " + (a / b));

            //Assignment Operator 
            //b += 6;

            //int a1 = Math.Min(a, b);
            //Double a2 = Math.Sqrt(49);
            //Console.WriteLine(a2);


            //string hello = "Namshkar!";
            //Console.WriteLine(hello.ToUpper());
            //Console.WriteLine(hello + "I'm self Vishnu Prakash");

            //string name = Console.ReadLine();
            //string candies = Console.ReadLine();
            //Console.WriteLine($"Your Name is {name}. You will get {candies}");

            var c1 = "Vishnu";
            Console.WriteLine(c1.GetType());

            Console.ReadLine();
        }
    }
}

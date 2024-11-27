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
            //int x1 = (int)3.5;
            //Console.WriteLine(x1);

            //Example of Implicit Casting
            int x2 = 5;
            float y = x2;
            double x3 = y;
            Console.WriteLine(x3);
            Console.ReadLine();


        }
    }
}

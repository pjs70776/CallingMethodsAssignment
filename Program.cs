using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main()
        {
            //ask the user what number they want to do the math
            //operations on.
            //method 1
            Console.WriteLine("What number do you want to select to do the math operation?");
            Console.WriteLine("Enter a number to be added to 5");
            int additon = Convert.ToInt32(Console.ReadLine());
            int sum = Class1.method1(additon);
            Console.WriteLine(sum + " is the answer.");

            //method 2
            Console.WriteLine("Enter a number to be multiplied by 5");
            int multi = Convert.ToInt32(Console.ReadLine());
            int product = Class1.method2(multi);
            Console.WriteLine(product + " is the answer.");

            //method 3
            Console.WriteLine("Enter a number to be divided by 5");
            int div = Convert.ToInt32(Console.ReadLine());
            int quot = Class1.method3(div);
            Console.WriteLine(quot + " is the answer.");
            Console.ReadLine();
        }
       
    }    
}

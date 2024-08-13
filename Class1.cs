using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsAssignment
{
    public class Class1
    {


        //create three methods, each of which will take one integer parameter
        //in and return an integer. The methods should do some math operation
        //on the received parameter.
        //three methods inside Class1
        //method1
        public static int method1(int x) 
        {
            int Add = x + 5; return Add;
        }
        //method 2
        public static int method2(int y) 
        {
            int Multiply = y * 5; return Multiply;
        }
        //method 3
        public static int method3(int z)
        {
            int Divide = z / 5; return Divide;
        }
    }
}

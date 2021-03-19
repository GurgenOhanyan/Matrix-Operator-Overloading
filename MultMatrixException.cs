using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class MultMatrixException:Exception
    {
        public MultMatrixException()
        {
            Console.WriteLine("The number of rows in the 1st matrix " +
                              "must be equal to the number of columns in the 2nd");
        }
    }
}

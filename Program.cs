using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        { 
            Matrix firstMatrix = new Matrix(2, 3);
            Matrix SecondMatrix = new Matrix(2, 3);
            Matrix.InitializationMatrix(firstMatrix);
            Console.WriteLine("------First  Matrix-----------------");
            Matrix.PrintMatrix(firstMatrix);
            Console.WriteLine("------Second Matrix-----------------");         
            Matrix.InitializationMatrix(SecondMatrix);
            Matrix.PrintMatrix(SecondMatrix);
            Console.WriteLine("------Third Matrix-----------------");
            Matrix thirdMatrix = new Matrix(3, 4);
            Matrix.InitializationMatrix(thirdMatrix);
            Matrix.PrintMatrix(thirdMatrix);
            Matrix fourthMatrix = new Matrix(4, 2);
            Matrix.InitializationMatrix(fourthMatrix);
            Console.WriteLine("------Fourth  Matrix---------------" );
            Matrix.PrintMatrix(fourthMatrix);

            try
            {
                Matrix SumMatrix = new Matrix(firstMatrix.row, firstMatrix.column);
                SumMatrix = firstMatrix + SecondMatrix;
                Console.WriteLine(" -----Sum Matrix ----- ----- ------- ");
                Matrix.PrintMatrix(SumMatrix);
                Console.WriteLine();
                bool b = firstMatrix == SecondMatrix;
                Console.WriteLine($"The matrices are equal to each other---{b}");
                Matrix MultMatrix = new Matrix(thirdMatrix.row, fourthMatrix.column);
                MultMatrix = thirdMatrix * fourthMatrix;
                Console.WriteLine("-----Multiplication Matrix----------------");
                Matrix.PrintMatrix(MultMatrix);
                Console.WriteLine();
                Console.WriteLine("-------conversion operator--------");
                int[] arr = new int[SecondMatrix.column * SecondMatrix.row];
                arr = (int[])SecondMatrix;
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i]+"  ");
                }
                Console.WriteLine();
            }
            catch (SumMatrixException)
            {

            }
            catch (MultMatrixException)
            { 
            }
        }
    }
}

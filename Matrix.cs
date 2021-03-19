using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Matrix
    {
        private  int[,] arr;
        public   int row { get; set; }
        public   int column { get; set; }
        public Matrix(int countRows, int countColumn)
        {
            this.row = countRows;
            this.column = countColumn;
            this.arr = new int[row, column];
        }
        public  static void InitializationMatrix(Matrix matrix)
        {
            Random obj = new Random();
            for (int i = 0; i <matrix.row; i++)
            {
                for (int j = 0; j <matrix.column; j++)
                {
                   matrix.arr[i, j] = obj.Next(1, 10);
                }
            }
        }
        public  static void PrintMatrix(Matrix matrix)
        {
            for (int i = 0; i <matrix.row; i++)
            {
                for (int j = 0; j<matrix.column; j++)
                {
                    Console.Write(matrix.arr[i,j]+"  ");
                }
                Console.WriteLine();
            }
        }
        public int this[int currentRow, int currentCoulmn]
        {
            get {return arr[currentRow, currentCoulmn]; }
            
                    
        }
        public static Matrix operator +(Matrix arr1, Matrix arr2)
        {
            if (arr1.row != arr2.row || arr1.column != arr2.column)
            {
                throw new SumMatrixException();
            }
            Matrix arr3 = new Matrix(arr1.row,arr1.column);
            for (int i = 0; i <arr1.row; i++)
            {
                for (int j = 0; j < arr1.column; j++)
                { 
                    arr3.arr[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            return arr3;
        }
        public static Matrix operator * (Matrix arr1, Matrix arr2)
        {
            if (arr1.column != arr2.row)
            {
                throw new MultMatrixException();
            }
            Matrix arr3 = new Matrix(arr1.row, arr2.column);
            for (int i = 0; i < arr1.row; i++)
            {
                for (int j = 0; j <arr2.column; j++)
                {
                    for (int k = 0; k < arr1.column; k++)
                    {
                        arr3.arr[i, j] += arr1[i, k] * arr2[k,j];
                    }
                }

            }
            return arr3;
        }
        public static bool operator ==(Matrix arr1, Matrix arr2)
        {
            if (arr1.row != arr2.row || arr1.column != arr2.column)
            {
                throw new SumMatrixException();
            }
            for (int i = 0; i < arr1.row; i++)
            {
                for (int j = 0; j < arr1.column; j++)
                {
                    if (arr1.arr[i, j] != arr2.arr[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool operator !=(Matrix arr1, Matrix arr2)
        {
            if (arr1.row != arr2.row || arr1.column != arr2.column)
            {
                throw new SumMatrixException();
            }
            for (int i = 0; i < arr1.row; i++)
            {
                for (int j = 0; j < arr1.column; j++)
                {
                    if (arr1.arr[i, j] != arr2.arr[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static implicit operator int [] (Matrix matrix)
        {
            int[] myarray = new int[matrix.column * matrix.row];
            int k = 0;
            for (int i = 0; i < matrix.row; i++)
            {
                for (int j = 0; j < matrix.column; j++)
                {
                    myarray[k] = matrix.arr[i, j];
                    k++;
                }
            }

            return myarray;
        }
    }
}

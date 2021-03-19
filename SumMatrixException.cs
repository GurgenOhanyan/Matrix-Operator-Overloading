using System;
class SumMatrixException : Exception
{
    public SumMatrixException()
    {
        Console.WriteLine("If the number of rows or columns is different," +
                        "  the amount of matrices is not defined;");
    }
}

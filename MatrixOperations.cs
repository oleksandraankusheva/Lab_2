using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public partial class MyMatrix
    {
        public static MyMatrix operator +(MyMatrix a, MyMatrix b)
        {
            int rowsA = a.Height;
            int colsA = a.Width;
            int rowsB = b.Height;
            int colsB = b.Width;
            MyMatrix result = new MyMatrix(rowsA, colsA);
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsA; j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }
            return result;
        }
        public static MyMatrix operator *(MyMatrix a, MyMatrix b)
        {
            int rowsA = a.Height;
            int colsA = a.Width;
            int colsB = b.Width;
            MyMatrix result = new MyMatrix(rowsA, colsB);
            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < colsB; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < colsA; k++)
                    {
                        sum += a[i, k] * b[k, j];
                    }
                    result[i, j] = sum;
                }
            }
            return result;
        }

        private double[,] GetTransponedArray()
        {
            int rows = Height;
            int cols = Width;
            double[,] transposedArray = new double[cols, rows];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    transposedArray[j, i] = matrix[i, j];
                }
            }
            return transposedArray;
        }

        public MyMatrix GetTransponedCopy()
        {
            double[,] transposedArray = GetTransponedArray();
            return new MyMatrix(transposedArray);
        }
        public void TransposeMe()
        {
            double[,] transposedArray = GetTransponedArray();
            matrix = transposedArray;
        }

        private MyMatrix(int rows, int cols)
        {
            matrix = new double[rows, cols];
        }
    }
}

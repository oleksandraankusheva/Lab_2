using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Program
    {
        static void PrintMatrix(double[,] nums)
        {
            for (int i = 0; i < nums.GetLength(0); i++)
            {
                for (int j = 0; j < nums.GetLength(1); j++)
                {
                    Console.Write(nums[i, j] + "\t");
                }
                Console.Write("\n");
            }
        }
        public static void Main(string[] args)
        {
            double[,] nums = new double[2, 3] { { 1, 2, 3 }, { 0, 8, 7 } };

            string line = "2 1 \n-3 0 \n4 -1 ";
            string[] arrOfLine = new[] { "5 -1 6", "-3 0 7" };

            double[][] jugArr = new double[3][];

            jugArr[0] = new double[] { 1, 3, 5 };
            jugArr[1] = new double[] { 0, 2, 6 };
            jugArr[2] = new double[] { 11, 22, 33 };

            MyMatrix matrixFromLine = new MyMatrix(line);

            Console.WriteLine("1 матриця утвореного рядка, matrix");
            Console.WriteLine(matrixFromLine);

            Console.WriteLine("Ширина і висота матриць та властивостi");
            Console.WriteLine(matrixFromLine.Width);
            Console.WriteLine(matrixFromLine.Height);

            MyMatrix matrixFromArrOfLine = new MyMatrix(arrOfLine);
            Console.WriteLine("1 матриця, утворена з масиву рядкiв - matrix1");
            Console.WriteLine(matrixFromArrOfLine);

            MyMatrix matrixFromNums = new MyMatrix(nums);
            Console.WriteLine("Третя матриця яка утворена з двомірного масиву, matrix2");
            Console.WriteLine(matrixFromNums);

            MyMatrix matrixJug = new MyMatrix(jugArr);
            Console.WriteLine("Матриця яка створена з зубчатого масиву");
            Console.WriteLine(matrixJug);


            MyMatrix sumOfMatrix = matrixFromArrOfLine + matrixFromNums;
            Console.WriteLine("Сума matrix1, matrix2");
            Console.WriteLine(sumOfMatrix);

            MyMatrix myltiplyerOfMatrixs = matrixFromLine * matrixFromArrOfLine;
            Console.WriteLine("Множення matrix, matrix1");
            Console.WriteLine(myltiplyerOfMatrixs);

            Console.WriteLine("Транспонована матрицz 1");
            MyMatrix transponedMarix = matrixFromLine.GetTransponedCopy();
            Console.WriteLine(transponedMarix);

            Console.ReadKey();
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public partial class MyMatrix
    {
        private double[,] matrix;

        public MyMatrix(MyMatrix other)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            this.matrix = new double[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    this.matrix[i, j] = other.matrix[i, j];
                }
            }
        }

        public MyMatrix(double[,] values)
        {
            int rows = values.GetLength(0);
            int cols = values.GetLength(1);
            this.matrix = new double[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    this.matrix[i, j] = values[i, j];
                }
            }
        }

        public MyMatrix(double[][] values)
        {
            int rows = values.Length;
            int cols = values[0].Length;

            this.matrix = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    this.matrix[i, j] = values[i][j];
                }
            }
        }

        public MyMatrix(string[] rows)
        {
            int rowCount = rows.Length;
            int colCount = rows[0].Split(' ').Length;
            this.matrix = new double[rowCount, colCount];
            for (int i = 0; i < rowCount; i++)
            {
                string[] values = rows[i].Split(' ');
                for (int j = 0; j < colCount; j++)
                {
                    this.matrix[i, j] = double.Parse(values[j]);
                }
            }
        }

        public MyMatrix(string input)
        {
            string[] rows = input.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            int rowCount = rows.Length;
            int colCount = rows[0].Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
            matrix = new double[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowValues = rows[i].Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                if (rowValues.Length != colCount)
                    throw new ArgumentException("Invalid row data");
                for (int j = 0; j < colCount; j++)
                {
                    if (!double.TryParse(rowValues[j], out matrix[i, j]))
                        throw new ArgumentException("Invalid value in row");
                }
            }
        }

        public int Height
        {
            get
            {
                return matrix.GetLength(0);
            }
        }

        public int Width
        {
            get
            {
                return matrix.GetLength(1);
            }
        }

        public int getHeight()
        {
            return Height;
        }

        public int getWidth()
        {
            return Width;
        }

        public double this[int row, int col]
        {
            get { return matrix[row, col]; }
            set { matrix[row, col] = value; }
        }

        public override string ToString()
        {
            int height = Height;
            int width = Width;
            string result = "";

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    result += matrix[i, j].ToString() + "\t";
                }
                result += "\n";
            }
            return result;
        }
    }
}

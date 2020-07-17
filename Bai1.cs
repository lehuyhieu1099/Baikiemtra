using System;
using System.Collections.Generic;
using System.Text;

namespace Array_and_Method
{
    class Bai1
    {
        public int[,] CreateMatrix(int side)
        {
            int[,] matrix = new int[side, side];
            Random rnd = new Random();
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    matrix[i, j] = rnd.Next(10, 90);
                }
            }
            return matrix;
        }
        public int SumOfEvenNumber(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }
        // Tổng đường chéo chính
        public int SumOfMainDiagonal(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, i];
            }
            return sum;
        }
        // Tổng đường chéo phụ
        public int SumOfExtraDiagonal(int[,] matrix)
        {
            int sum = 0;
            int m = matrix.GetLength(0);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                m--;
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    if (j == m)
                    {
                        sum = sum + matrix[i, j];
                    }
                }
            }
            return sum;
        }

        // Tổng đường biên
        public int SumOfBorderLine(int[,] matrix)
        {
            int sum = 0;
            int row = matrix.GetLength(0);
            {
                for (int i = 0; i < row; i++)
                {
                    sum += matrix[0, i];
                }
                for (int i = 1; i < row; i++)
                {
                    sum += matrix[i, 0];
                }
                for (int i = 1; i < row; i++)
                {
                    sum += matrix[row - 1, i];
                }
                for (int i = 1; i < row - 1; i++)
                {
                    sum += matrix[i, row - 1];
                }
                return sum;
            }
        }
        // Hiển thị matrix
        public void ShowMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        // Tạo tam giác dưới
        public void CreatUnderTritangle(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("\n");
                for (int j = 0; j < matrix.GetLength(0); j++)
                    if (i >= j)
                        Console.Write($"{matrix[i, j]} ");
                    else
                        Console.Write("*  ");
            }
        }
        public void CreatAboveTritangle(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write("\n");
                for (int j = 0; j < matrix.GetLength(0); j++)
                    if (i < j)
                        Console.Write($"{matrix[i, j]} ");
                    else
                        Console.Write("*  ");
            }
        }


    }
}

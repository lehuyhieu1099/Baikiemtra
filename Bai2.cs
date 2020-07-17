using System;
using System.Collections.Generic;
using System.Text;

namespace Array_and_Method
{
    class Bai2
    {
        public int[,] CreateMatrix1(int side)
        {
            int[,] matrix = new int[side, side];
            Random rnd = new Random();
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    matrix[i, j] = rnd.Next(10, 40);
                }
            }
            return matrix;
        }
        public int[,] CreateMatrix2(int side)
        {
            int[,] matrix = new int[side, side];
            Random rnd = new Random();
            for (int i = 0; i < side; i++)
            {
                for (int j = 0; j < side; j++)
                {
                    matrix[i, j] = rnd.Next(10, 40);
                }
            }
            return matrix;
        }
        //Gọi C là mảng chứa tổng của hai mảng trên
        public int[,] Sumof2Matrix(int[,] A, int[,] B)
        {
            int n = A.GetLength(0);
            int[,] C = new int[n,n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }
            return C;
        }
        //Gọi D là mảng chứa tích của hai mảng trên
        public int[,] MultiOf2Matrix(int[,] A, int[,] B)
        {
            int n = A.GetLength(0);
            int[,] D = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int k = 0; k < n; k++)
                {
                    D[i, k] = 0;
                    for (int j = 0; j < n; j++)
                    {
                        D[i, k] +=  A[i, j] * B[j, k];
                    }
                }
            return D;
        }
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

    }
}

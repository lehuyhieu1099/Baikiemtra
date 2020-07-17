using System;
using System.Collections.Generic;
using System.Text;

namespace Array_and_Method
{
    class Bai3
    {
        public  int[,] CreateMatrix(int row, int col)
        {
            int[,] matrix = new int[row, col];
            Random rnd = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = rnd.Next(20, 60);
                }
            }
            return matrix;
        }
        public int[,] Findv(int v, int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i,j] != v)
                    {
                        matrix[i, j] = 0;
                    }
                    else
                    {
                        matrix[i, j] = matrix[i,j];
                    }                        
                }
            }
            return matrix; 
        }
        public int[,] FindMultiplesOf5( int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] % 5 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                    else
                    {
                        matrix[i, j] = matrix[i, j];
                    }
                }
            }
            return matrix;
        }
        public void ShowMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        // Tạo ma trận kích thước ngược lại 
        public int[,] CreateMatrix2(int [,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);
            int[,] matrix2 = new int[m, n];
            Random rnd = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix2[i, j] = rnd.Next(20, 60);
                }
            }
            return matrix2;
        }

    }
}

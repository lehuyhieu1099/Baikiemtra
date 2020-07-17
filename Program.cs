using System;

namespace Array_and_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bài 1:
            //Bai1 bai1 = new Bai1();

            //Console.WriteLine("Bai1: \n");
            //var matrix = bai1.CreateMatrix(10);
            //bai1.ShowMatrix(matrix);
            //Console.WriteLine("Tong cac so chan: " + bai1.SumOfEvenNumber(matrix));
            //Console.WriteLine("Tong duong cheo chinh: " + bai1.SumOfMainDiagonal(matrix));
            //Console.WriteLine("Tong duong cheo phu: " + bai1.SumOfExtraDiagonal(matrix));
            //Console.WriteLine("Tong duong bien: " + bai1.SumOfBorderLine(matrix));
            //bai1.CreatUnderTritangle(matrix);
            //Console.WriteLine();
            //bai1.CreatAboveTritangle(matrix);


            //Console.WriteLine("Bai2: \n");

            //Bai2 bai2 = new Bai2();
            //var matrix1 = bai2.CreateMatrix1(3);
            //var matrix2 = bai2.CreateMatrix2(3);
            //bai2.ShowMatrix(matrix1);
            //Console.WriteLine();
            //bai2.ShowMatrix(matrix2);
            //Console.WriteLine();
            //var summatrix = bai2.Sumof2Matrix(matrix1, matrix2);
            //bai2.ShowMatrix(summatrix);
            //Console.WriteLine();
            //var multimatrix = bai2.MultiOf2Matrix(matrix1, matrix2);
            //bai2.ShowMatrix(multimatrix);

            //Bài 3:
            Console.WriteLine("Bai3: \n");
            Bai3 bai3 = new Bai3();
            var matrix3 = bai3.CreateMatrix(5, 4);
            bai3.ShowMatrix(matrix3);
            //Console.WriteLine("Enter V: ");
            //int v = int.Parse(Console.ReadLine());
            //var vmatrix = bai3.Findv(v, matrix3);
            //bai3.ShowMatrix(vmatrix);
            //var matrixof5 = bai3.FindMultiplesOf5(matrix3);
            //bai3.ShowMatrix(matrixof5);
            Console.WriteLine();
            var matrix_3 = bai3.CreateMatrix2(matrix3);
            bai3.ShowMatrix(matrix_3);





        }
    }
}

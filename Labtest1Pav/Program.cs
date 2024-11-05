using Labtest1Pav;
using System;
using static Labtest1Pav.Class1;



int[] matrixRow = new int[15] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

Console.Write("Введите количество строк для нижней треугольной матрицы (1-5): ");
int rows = Convert.ToInt32(Console.ReadLine());

    if (rows < 1 || rows > 5)
    {
        Console.WriteLine("Количество строк должно быть от 1 до 5.");
        return;
    }

int[,] lowerTriangularMatrix = BuildLowerTriangularMatrix(matrixRow, rows);

PrintMatrix(lowerTriangularMatrix);
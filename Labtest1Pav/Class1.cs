using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labtest1Pav
{
    public class Class1
    {
        public static int[,] BuildLowerTriangularMatrix(int[] matrixRow, int rows)
        {
            // Создаем нижнюю треугольную матрицу
            int[,] lowerTriangularMatrix = new int[rows, rows];

            // Заполняем нижнюю треугольную матрицу
            int index = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (index < matrixRow.Length)
                    {
                        lowerTriangularMatrix[i, j] = matrixRow[index];
                        index++;
                    }
                    else
                    {
                        lowerTriangularMatrix[i, j] = 0; // Заполняем нулями, если элементов не хватает
                    }
                }
            }

            return lowerTriangularMatrix;
        }

        public static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
// Задача 53:
// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; 
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 5}");
        }
        Console.WriteLine("  |");
    }
}

void ReplaceFirstLastRows(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(1); rows++)
    {
        int temp = matrix[0,rows];
        matrix[0,rows] = matrix[matrix.GetLength(0) - 1, rows];
        matrix[matrix.GetLength(0) - 1, rows] = temp;
    }
}

int[,] res = CreateMatrixRndInt(3,3,1,10);
PrintMatrix(res);
Console.WriteLine("--------------------");
ReplaceFirstLastRows(res);
PrintMatrix(res);

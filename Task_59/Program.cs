// Задача 59:
// Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
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
            Console.Write($" {matrix[i, j], 6}");
        }
        Console.WriteLine("    |");
    }
   
}

int[] GetIndexesMinElem(int[,] matrix)
{
    int rowMin = 0;
    int columnMin = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       for (int j = 0; j < matrix.GetLength(1); j++) 
       {
            if (matrix[i,j] <=matrix[rowMin, columnMin])
            {
                rowMin = i;
                columnMin = j;
            }
       }
    }
    return new int[] {rowMin, columnMin};
} 
int [,] DeleteRowColumnMinElem(int[,] matrix, int delRow, int delColumn)
{
    int[,] littleMatrix = new int[matrix.GetLength(0)-1, matrix.GetLength(1)-1];
    for (int i = 0, m = 0; i < littleMatrix.GetLength(0); i++, m++)
    {
        if (i == delRow) m++;
        for (int j = 0, n = 0; j < littleMatrix.GetLength(1); j++,n++)
        {
            if (j == delColumn) n++;
            littleMatrix[i, j] = matrix[m,n];

        }
    }
    return littleMatrix;
}

int[,] array2d = CreateMatrixRndInt(5, 5, -10, 10);
PrintMatrix(array2d);
int[] indexesMinElem = GetIndexesMinElem(array2d);
int[,] deleteRowColumnMinElem = DeleteRowColumnMinElem(array2d, indexesMinElem[0], indexesMinElem[1]);
Console.WriteLine();
PrintMatrix(deleteRowColumnMinElem);
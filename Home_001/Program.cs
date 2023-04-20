// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Nach();

void Nach()
{

    int[,] matrix = new int[5,6];
    GetArray(matrix);
    PrintMatrix(matrix);
    SorToTabl(matrix);
    Console.WriteLine();
    PrintMatrix(matrix);
    
}


void GetArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j  < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(-5, 7);
        }
    
    }

}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j  < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");

        }
        System.Console.WriteLine();
    }
}

void SorToTabl(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int n = 0; n < matrix.GetLength(1) - 1; n++)
            {
                if (matrix[i,n] < matrix[i,n + 1])
                {
                    int num = 1;
                    num = matrix[i,n + 1];
                    matrix[i,n + 1] = matrix[i,n];
                    matrix[i,n] = num;
                }
            }
        }
    }
}


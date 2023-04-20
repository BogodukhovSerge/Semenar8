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
    int rows = Bass("rows");
    int columns = Bass("columns");

    double[,] matrix = GetArrayDouble(rows, columns, -5, 10);
    PrintMatrix(matrix);
    Console.WriteLine();
    GetSredArifNym(matrix);
}

int Bass(string sms)
{
    System.Console.WriteLine(sms);
    String readInput = System.Console.ReadLine();
    int result = int.Parse(readInput);
    return result;
}

double[,] GetArrayDouble(int rows, int colums, int min, int max)
{
    double[,] array = new double[rows, colums];
    var rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i,j] = rand.Next(min, max + 1);
        }
    
    }
    return array;

}

void PrintMatrix(double[,] matrix)
{
    for (int m = 0; m < matrix.GetLength(0); m++)
    {
        for (int n = 0; n  < matrix.GetLength(1); n++)
        {
            System.Console.Write($"{matrix[m, n]} ");

        }
        System.Console.WriteLine();
    }
}

// void GetSredArifNym(double[,] matrix)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         int count = 0;
//         double res = 0;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             res = res + matrix[i,j];
//             count++;
//         }
//         res = res / count;
//         Console.WriteLine($"{j+1} {res}");
//     }
// }

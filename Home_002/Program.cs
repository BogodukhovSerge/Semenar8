// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка

Console.Write("Введите размер массива m на n и диапазон случайных значений: ");
int m = InPutNum("Введите m: ");
int n = InPutNum("Введите n: ");
//int ray = InPutNum("Введите диапазон: от -5 до 10");

int[,] array = new int[m, n];
CreatArray(array);
WriteArray(array);
MinSumStrok(array);
Console.WriteLine($"\n{MinSumStrok} - Stroka s naimenshey sum ");




int InPutNum(string InPut)
{
    Console.Write(InPut);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}



void CreatArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i,j] = new Random().Next(-5, 10);
            }

    }
}

int SumStrokElement(int[,] array, int i)
{
    int SumStrok = array[i,0];
    for (int j = 0; j < array.GetLength(1); j++)    
    {
        SumStrok += array[i,j];
    }
    return SumStrok;
}

int MinSumStrok(int[,] array)
{
    int minSum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int tempSumStrok = SumStrokElement(array, i);
        if (minSum > tempSumStrok)
        {
            minSum = tempSumStrok;
            minSum = i;

        }

    }
    return minSum;
}

void WriteArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]);
        }
    }
}
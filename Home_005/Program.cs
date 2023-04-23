// Задача 62. Напишите программу, которая заполнит спирально массив . 
// Размер вводит юзер
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int k = 5;
int[,] speralMatrix = new int[k, k];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= speralMatrix.GetLength(0) * speralMatrix.GetLength(1))
{
  speralMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < speralMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= speralMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > speralMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(speralMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}
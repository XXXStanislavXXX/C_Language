/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

#nullable disable

int arrayLength = SetNumber("Enter array length ");
int[,] sqareMatrix = new int[arrayLength, arrayLength];

int digit = 1;
int x = 0;
int y = 0;

while (digit <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[x, y] = digit;
  digit++;
  if (x <= y + 1 && x + y < sqareMatrix.GetLength(1) - 1)
    y++;
  else if (x < y && x + y >= sqareMatrix.GetLength(0) - 1)
    x++;
  else if (x >= y && x + y > sqareMatrix.GetLength(1) - 1)
    y--;
  else
    x--;
}

WriteArray(sqareMatrix);

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

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}  
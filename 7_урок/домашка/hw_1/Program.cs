/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

#nullable disable

Console.WriteLine("Enter raws quantity  ");
int raws = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter columns quantity ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double[raws, columns];

FillArrayRandomNumbers(numbers);

PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int l = 0; l < array.GetLength(1); l++)
        {
            array[i, l] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    System.Console.WriteLine();
    System.Console.WriteLine("Your Random Array: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write("[ ");
        for (int l = 0; l < array.GetLength(1); l++)
        {
            System.Console.Write(array[i, l] + " ");
        }
        System.Console.Write("]");
        System.Console.WriteLine("");
    }
}
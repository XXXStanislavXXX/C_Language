/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

#nullable disable

int posX = SetNumber("of element raw ");

int posY = SetNumber("of element column ");

int raws = SetNumber("of quantity of raws for array");

int columns = SetNumber("of quantity of columns for array");

double[,] numbers = new double[raws, columns];

FillArrayRandomNumbers(numbers);

PrintArray(numbers);

Search(posX, posY);

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

void Search(int posX, int posY)
{
    System.Console.WriteLine();
    if (posX < 0 | posX > numbers.GetLength(0) - 1 | posY < 0 | posY > numbers.GetLength(1) - 1)
    {
        System.Console.WriteLine("Element doesnt exist ");
    }
    else
    {
        System.Console.WriteLine("Element number is = {0}", numbers[posX, posY]);
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

int SetNumber(string numberName)
{
    System.Console.WriteLine($"Enter number {numberName}: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}
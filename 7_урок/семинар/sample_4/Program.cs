﻿/*
Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

#nullable disable

int numRows = SetNumber("Rows ");
int numColumns = SetNumber("Columns ");

int numMaxValue = SetNumber("Max number ");
int numMinValue = SetNumber("Min number ");

var matrix = GetMatrix(numRows, numColumns, numMinValue, numMaxValue);
Print(matrix);
System.Console.WriteLine();
System.Console.WriteLine(DigitsSumm(matrix));


int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int[,] GetMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i, l] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}

void Print(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            System.Console.Write(matrix[i, l] + " ");
        }
        System.Console.WriteLine();
    }
}

void CheckValue(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            if (isEven(i, l))
            {
                matrix[i, l] *= matrix[i, l];
            }
        }

    }
}

bool isEven(int i, int l)
{
    return i == l;
}

int DigitsSumm(int[,] matrix)
{
    int Sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            if (isEven(i, l))
            {
                Sum += matrix[i, l];
            }
        }
    }
    return Sum;
}
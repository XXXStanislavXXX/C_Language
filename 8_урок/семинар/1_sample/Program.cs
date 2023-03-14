/*
Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
*/

#nullable disable

int [,] Massiv = GetIntMatrix(4, 4, 1, 10);

PrintInt(Massiv);
System.Console.WriteLine();
Revers(Massiv);
PrintInt(Massiv);

int [,] GetIntMatrix(int Rows, int Colums, int min, int max)        //рандомная интовая матрица
{
    int [,] matrix = new int [Rows, Colums];
    for (int i = 0; i < Rows; i++)
    {
        for (int j = 0; j < Colums; j++)
        {
            matrix[i,j] = new Random().Next(min, max+1);
        }
    }
    return matrix;
}


void PrintInt(int [,] matrixInt)               // Выводим нашу матрицу инт
{
    for (int i = 0; i < matrixInt.GetLength(0); i++)
    {
        for (int j = 0; j < matrixInt.GetLength(1); j++)
        {
            System.Console.Write(matrixInt[i,j] + " ");
        }
        System.Console.WriteLine();
    } 
}


void Revers(int [,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) -1, i];
        matrix[matrix.GetLength(0) -1, i]  = temp;

    }
    
}

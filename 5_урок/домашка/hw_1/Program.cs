﻿/*
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

#nullable disable

System.Console.WriteLine("Enter array legth: ");
int length = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter array minimal: ");
int min = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter array maximal: ");
int max = int.Parse(Console.ReadLine());

int[] Array = GetArray(length, min, max);

System.Console.WriteLine($"[{string.Join(", ", Array)}]");

FindEven(Array);

int[] GetArray (int size, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] result = new int[size];
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue+ 1);        
    }
    return result;
}

void FindEven(int[] MyArray)
{
    int even=0;
    for (int i= 0; i< MyArray.Length; i++)
    {
        if (MyArray [i] %2 == 0)
        {
            even += 1;
        }    
    }
    
    System.Console.WriteLine($"even digits number: {even}");
}

 /*
 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

#nullable disable

System.Console.WriteLine("Enter a number ");
int Length = int.Parse(Console.ReadLine());

int[] array = new int[Length];

for (int i = 0; i < Length; i++)

{

array[i] = new Random().Next(Length+1);
Console.Write(array[i] + "; ");

}

Console.WriteLine();
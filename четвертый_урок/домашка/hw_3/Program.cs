 /*
 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

#nullable disable

int [] myArray;
myArray = new int [8];

for (int i = 0; i < myArray.Length; i++)
{
    System.Console.WriteLine("Enter your number ");
    int digit = int.Parse(Console.ReadLine());
    myArray[i] = digit;
}

Console.WriteLine(string.Join(", ", myArray) + " -> " + "[" + string.Join(", ", myArray) + "]");

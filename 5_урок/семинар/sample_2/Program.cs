/*
Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да
*/

#nullable disable

int [] Array = GetArray(4, -8, 8);
System.Console.WriteLine(String.Join(" ", Array));
System.Console.WriteLine("Enter digit ");
int digit = int.Parse(Console.ReadLine());
int [] GetArray(int size, int minimum, int maximum)
{
    int [] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minimum, maximum + 1);
    } 

    return res;
}
bool FindElement(int[] array, int el)
{
    foreach (var item in array)
    {
        if (el == item) return true;
    }
    return false;
}

if (FindElement(Array, digit))
{
    System.Console.WriteLine("[" + String.Join(" ", Array) + "]" + "-> Да");
}
else
{
    System.Console.WriteLine("[" + String.Join(" ", Array) + "]" + " -> Нет");
}

/*
Напишите программу, которая будет преобразовывать
десятичное число в двоичное.
45
--> 101101
3
--> 11
2
--> 10
*/

#nullable disable

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());

int[]Numbers(int num)
{
    int size = 32;
    int [] result = new int [size];
    for (int i = 0; i < size; i++)
    {
        result[i]= num % 2;
        num /=2;
    }
    return result;
}
int[] Binary = (Numbers(number));
Array.Reverse(Binary);
Console.WriteLine("Полученный массив = "+ String.Join(" ", Binary));
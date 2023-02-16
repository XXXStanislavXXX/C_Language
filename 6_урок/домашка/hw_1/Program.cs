/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

#nullable disable

Console.Write("Enter your digits (use space as divider) ");
int[] MyArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int Counter (int [] MyArray)
{ 
    int count = 0;

    for (int i = 0; i < MyArray.Length; i++)
    {
        if (MyArray[i] > 0)
        {
            count++;
        }
    }
    return count;
}
 
Console.WriteLine($"Digits > 0 quantaty is : {Counter(MyArray)}");

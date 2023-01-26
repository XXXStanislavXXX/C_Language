/*
Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите число 1 ");

int chislo_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2 ");

int chislo_2 = Convert.ToInt32(Console.ReadLine());

if (chislo_1 > chislo_2)
{
    System.Console.Write("max = ");
    System.Console.Write(chislo_1);
}
else
{
    System.Console.Write("max = ");
    System.Console.Write(chislo_2);
}

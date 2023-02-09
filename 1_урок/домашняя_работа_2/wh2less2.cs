/*
Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите число 1 ");

int chislo_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2 ");

int chislo_2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 3 ");

int chislo_3 = Convert.ToInt32(Console.ReadLine());

if (chislo_1 > chislo_2 && chislo_1 > chislo_3)
{
    System.Console.Write("max = ");
    System.Console.Write(chislo_1);
}
else if(chislo_2 > chislo_1 && chislo_2 > chislo_3)
{
    System.Console.Write("max = ");
    System.Console.Write(chislo_2);
}
else
{
    System.Console.Write("max = ");
    System.Console.Write(chislo_3);
}

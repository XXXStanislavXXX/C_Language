/*
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Введите число ");

int chislo = Convert.ToInt32(Console.ReadLine());

if(chislo % 2 == 0)
{
    System.Console.WriteLine("да ");
}
    else
    {
        System.Console.WriteLine("нет ");
    }

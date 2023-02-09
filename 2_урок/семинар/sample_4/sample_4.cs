/*
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25  ->  да
-4, 16  ->  да
25, 5  ->  да
8,9  ->  нет
*/

System.Console.WriteLine("Введи первое число ");
int chislo1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введи первое число ");
int chislo2 = Convert.ToInt32(Console.ReadLine());

if (chislo1 * chislo1 == chislo2 || chislo2 * chislo2 == chislo1)
{
    System.Console.WriteLine("является ");
}
else
{
    System.Console.WriteLine("не является ");
}

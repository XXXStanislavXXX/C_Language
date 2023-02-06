/*
Напишите программу, которая на вход принимает N а выдает сумму чисел от 1 до N
*/

# nullable disable
System.Console.WriteLine("Enter number N ");
int num = int.Parse(Console.ReadLine());

if (num < 1)
{
    System.Console.WriteLine("Number less than 1 ");
}
else
{
    int summ = 0;
    for (int i = 1; i <= num; i++)
    {
        summ += i;
    }
    System.Console.WriteLine("Summ is = " + summ);
}
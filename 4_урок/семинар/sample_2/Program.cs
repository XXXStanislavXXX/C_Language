/*
Напишите программу, которая на вход принимает N а выдает сумму чисел от 1 до N (через метод)
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
System.Console.WriteLine("Summ of digits is " + GetSumm(num));
}
int GetSumm (int num)
{
        int summ = 0;
    for (int i = 1; i <= num; i++)
    {
        summ += i;
    }

    return (summ);
}
/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

int digit;

while (true)
{
    System.Console.WriteLine("Enter your digit ");
    digit = int.Parse(Console.ReadLine());
    if (digit >=10000 && digit <= 99999)
    {
    break;
    }
}

if (digit % 10 == digit / 10000 && digit % 100 / 10 == digit / 1000 % 10)
{
    System.Console.WriteLine("Number " + digit + " is a palindrome");
}
else
{
    System.Console.WriteLine("Number " + digit + " is not a palindrome");
}

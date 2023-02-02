/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

#nullable disable

int digit;
int compare_digit;

while (true)
{
    System.Console.WriteLine("Enter your digit ");
    digit = int.Parse(Console.ReadLine());
    compare_digit = Math.Abs(digit);

    if (compare_digit >=10000 && compare_digit <= 99999)
    {
    break;
    }
}

if (compare_digit % 10 == compare_digit / 10000 && compare_digit % 100 / 10 == compare_digit / 1000 % 10)
{
    System.Console.WriteLine("Number " + digit + " is a palindrome");
}
else
{
    System.Console.WriteLine("Number " + digit + " is not a palindrome");
}

/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/

System.Console.WriteLine("Enter your number ");
int num = int.Parse(Console.ReadLine());
int num_primal = num;
int rev_num = 0;

while (num > 0) 
{
    rev_num = rev_num * 10 + num % 10;
    num = num / 10;
}

if (num_primal == rev_num)
{
    System.Console.WriteLine("Your number " + num_primal + " is a palindrome");
}
else
{
    System.Console.WriteLine("Your number " + num_primal + " is not a palindrome");
}

/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

#nullable disable

System.Console.WriteLine("Enter your number ");
int num = int.Parse(Console.ReadLine());
int num_compare = Math.Abs(num);
int num_primal = num_compare;
int rev_num = 0;

while (num_compare > 0) 
{
    rev_num = rev_num * 10 + num_compare % 10;
    num_compare = num_compare / 10;
}

if (num_primal == rev_num)
{
    System.Console.WriteLine("Your number " + num + " is a palindrome");
}
else
{
    System.Console.WriteLine("Your number " + num + " is not a palindrome");
}

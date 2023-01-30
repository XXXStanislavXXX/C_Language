/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день 
выходным.

6 -> да
7 -> да
1 -> нет
*/

System.Console.WriteLine("Enter your day number ");

int digit = (Convert.ToInt32(Console.ReadLine()));

while (digit > 7)
{
    digit = digit % 7;
}
int number = digit;

System.Console.WriteLine(number);
if (number == 6 || number == 7 || number == 0)
{
    System.Console.WriteLine("yes ");
}
else
{
    System.Console.WriteLine("no ");
}

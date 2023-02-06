/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/

#nullable disable

System.Console.WriteLine("Enter your number "); // Задаем наше число
int num = int.Parse(Console.ReadLine());

int SummNum(int number)
{
    int digit = 0;
    while(num > 1)
    {
        digit = digit + num % 10;
        num /= 10;
    }
    return digit;
}
System.Console.WriteLine(num + " -> " + SummNum(num));

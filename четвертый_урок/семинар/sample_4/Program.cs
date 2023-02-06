/*
Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
*/

# nullable disable

System.Console.WriteLine("Enter your number");
int digit = int.Parse(Console.ReadLine());

if (digit < 1)
{
    System.Console.WriteLine("Your number less than 1 ");
}
else
{
System.Console.WriteLine(NumberMulti(digit));
}
int NumberMulti (int digit)
{
    int result = 1;
    for (int i = 1; i <= digit; i++)
    {
        result *= i;
    }
    return result;
}

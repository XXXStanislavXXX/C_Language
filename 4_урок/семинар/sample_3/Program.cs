/*
Напишите программу, которая принимает на вход число и выдает количество цифр в числе
*/

#nullable disable

System.Console.WriteLine("Enter your number ");
int num = int.Parse(Console.ReadLine());

if (num < 1)
{
    System.Console.WriteLine("Your number is less than 1 ");
}
else
{

}

int NumberLenght (int num)
{
    int count = 0;
while (num > 0)
{
    num = num / 10;
    count = count + 1;
}
return count;
}

System.Console.WriteLine(NumberLenght(num));

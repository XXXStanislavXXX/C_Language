/*
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

System.Console.WriteLine("Enter your number: ");

int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100)
{
    while (number > 999)
    {
        number = number / 10;
    }
    int result = number %10;

    System.Console.WriteLine(result);
}
else
{
    System.Console.WriteLine("There is no 3rd digit ");
}

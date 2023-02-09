/*
Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/

System.Console.WriteLine("введите число 1 ");
int number1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("введите число 2 ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 % number1 == 0)
{
    System.Console.WriteLine($"Ваши числа {number1} и {number2}");
}
else
{
    System.Console.WriteLine(number2 % number1);
}

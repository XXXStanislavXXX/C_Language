﻿/*
Напишите программу, которая выводит случайное число
из отрезка [10, 99] и показывает наибольшую цифру числа.
*/

int number = new Random().Next(10, 100);
System.Console.WriteLine(number);

int number1 = number / 10;

int number2 = number % 10;

if (number1 > number2)
{
    System.Console.WriteLine("максимальное число " + number1);
}
else if (number2 > number1)
{
    System.Console.WriteLine("максимальное число " + number2);
}
else
{
    System.Console.WriteLine("Числа равны!");
}

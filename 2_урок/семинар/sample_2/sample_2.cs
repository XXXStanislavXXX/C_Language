/*
Напишите программу, которая выводит случайное трехзначное число 
и удаляет вторую цифру этого числа.
*/

int number = new Random().Next(100, 999);
System.Console.WriteLine(number);

int number1 = number / 100;

int number2 = number % 10;

// System.Console.WriteLine($"{number1}{number2}");

int result = number1*10 + number2;

System.Console.WriteLine(result);

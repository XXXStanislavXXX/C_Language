/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21
*/

#nullable disable

System.Console.WriteLine("enter coordinates point xA ");
int xA = int.Parse(Console.ReadLine());

System.Console.WriteLine("enter coordinates point xB");
int xB = int.Parse(Console.ReadLine());

System.Console.WriteLine("enter coordinates point yA");
int yA = int.Parse(Console.ReadLine());

System.Console.WriteLine("enter coordinates point yB");
int yB = int.Parse(Console.ReadLine());

// System.Console.WriteLine($"{Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA))}");

double result =  Math.Round((Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA))), 2);
System.Console.WriteLine(result);


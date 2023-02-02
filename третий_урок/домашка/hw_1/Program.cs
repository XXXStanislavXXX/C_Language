/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

System.Console.WriteLine("enter coordinates point xA ");
int xA = int.Parse(Console.ReadLine());

System.Console.WriteLine("enter coordinates point xB");
int xB = int.Parse(Console.ReadLine());

System.Console.WriteLine("enter coordinates point yA");
int yA = int.Parse(Console.ReadLine());

System.Console.WriteLine("enter coordinates point yB");
int yB = int.Parse(Console.ReadLine());

System.Console.WriteLine("enter coordinates point zA");
int zA = int.Parse(Console.ReadLine());

System.Console.WriteLine("enter coordinates point zB");
int zB = int.Parse(Console.ReadLine());

// System.Console.WriteLine($"{Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA))}");

double result =  Math.Round((Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA) + (zB - zA) * (zB - zA))), 2);
System.Console.WriteLine(result);
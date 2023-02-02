/*
Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/

#nullable disable

System.Console.WriteLine("Enter number x ");
int num_x = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter number y ");
int num_y = int.Parse(Console.ReadLine());

if (num_x > 0 && num_y > 0)
{
    System.Console.WriteLine("1 section ");
}
else if (num_x < 0 && num_y > 0)
{
    System.Console.WriteLine("2 section ");
}
else if (num_x < 0 && num_y < 0)
{
    System.Console.WriteLine("3 section ");
}
else if (num_x > 0 && num_y < 0)
{
    System.Console.WriteLine("4 section ");
}
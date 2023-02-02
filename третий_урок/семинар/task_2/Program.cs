/*
Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/

#nullable disable

int quarter;

while (true)
{
    System.Console.WriteLine("Enter quarter number ");
    quarter = int.Parse(Console.ReadLine());
    if (quarter >=1 && quarter <= 4)
    {
    break;
    }
}

if (quarter == 1)
{
    System.Console.WriteLine("x > 0 y > 0 ");
}
else if (quarter == 2)
{
    System.Console.WriteLine("x > 0 y < 0");
}
else if (quarter == 3)
{
    System.Console.WriteLine("x < 0 y > 0 ");
}
else if (quarter == 4)
{
    System.Console.WriteLine("x < 0 y < 0");
}
// else
// {
//     System.Console.WriteLine("Enter number 1-4");
// }
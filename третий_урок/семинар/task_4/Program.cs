/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.
*/

#nullable disable

System.Console.WriteLine("enter nubler ");
int digit = int.Parse(Console.ReadLine());
int start = 1;
while(start <= digit )
{
    double result = Math.Pow(start, 2 );
    start ++ ;
    System.Console.Write(result + ", ");
}

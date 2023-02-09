/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

#nullable disable

System.Console.WriteLine("Enter number A ");
int numberA = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter number B ");
int numberB = int.Parse(Console.ReadLine());

int Multiply(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result *= numberA;
    }
    return result;
}

System.Console.WriteLine(Multiply(numberA, numberB));

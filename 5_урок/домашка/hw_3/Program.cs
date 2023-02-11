/*
 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

#nullable disable

Console.WriteLine("Enter array legth  ");
int Length = int.Parse(Console.ReadLine());

double[] digits = new double[Length];

FillArrayRandomDigits(digits);
Console.WriteLine("Your Array: ");

PrintArray(digits);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < digits.Length; i++)
{
    if (digits[i] > max)
        {
            max = digits[i];
        }
    if (digits[i] < min)
        {
            min = digits[i];
        }
}

Console.WriteLine($"Your array length is: {digits.Length}. Your max number is = {max}, your minimal number is = {min}");
Console.WriteLine($"Yur max, min difference is = {max - min}");

void FillArrayRandomDigits(double[] digits)
{
    for(int i = 0; i < digits.Length; i++)
        {
            digits[i] = Convert.ToDouble(new Random().Next(100,100000)) / 100;
        }
}
void PrintArray(double[] digits)
{
    Console.Write("[ ");
    for(int i = 0; i < digits.Length; i++)
        {
            Console.Write(digits[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

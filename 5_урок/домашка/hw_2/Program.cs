/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

#nullable disable

System.Console.WriteLine("Enter array legth: ");
int length=int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Enter array minimal: ");
int min=int.Parse(Console.ReadLine()!);

System.Console.WriteLine("Enter array maximal: ");
int max=int.Parse(Console.ReadLine()!);

int[] Array= GetArray(length, min, max);

System.Console.WriteLine($"[{string.Join(", ", Array)}]");

FindOddness (Array);

int[] GetArray(int size, int minValue, int maxValue)
{
    
    Random rnd= new Random();
    int [] result= new int[size];
    for (int i= 0; i< result.Length; i++)
    {
        result [i] = rnd.Next(minValue, maxValue+ 1);        
    }
    return result;
}

void FindOddness (int[] MyArray)
{
    int odd = 0;
    for(int i = 1; i < MyArray.Length; i=i+2)
    {
        odd = odd + MyArray[i];
    }

    System.Console.WriteLine($"Oddness summ = {odd}");
}

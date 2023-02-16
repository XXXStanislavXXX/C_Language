/*
Напишите программу, которая перевернёт
одномерный массив (последний элемент будет на первом
месте, а первый на последнем и т.д.)
[1 2 3 4 5]
--> [5 4 3 2
[6 7 3 6]
--> [6 3 7
*/

#nullable disable

System.Console.WriteLine("Enter array legth: ");
int length = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter array minimal: ");
int min = int.Parse(Console.ReadLine());

System.Console.WriteLine("Enter array maximal: ");
int max = int.Parse(Console.ReadLine());

int[] MyArray = GetArray(length, min, max);

System.Console.WriteLine($"[{string.Join(", ", MyArray)}]");

int[] GetArray (int size, int minValue, int maxValue)
{
    Random rnd = new Random();
    int[] result = new int[size];
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue+ 1);        
    }
    return result;
}

Array.Reverse(MyArray);

System.Console.WriteLine($"[{string.Join(", ", MyArray)}]");
/*
выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5
--> 0 1 1 2 3
Если N = 3
--> 0 1 1
Если N = 7
--> 0 1 1 2 3 5 8
*/

#nullable disable

Console.WriteLine("До какого числа считать ряд Фибоначчи?");
int number = Convert.ToInt32(Console.ReadLine());

int perv = 0;
Console.Write(" " + perv);
int vtor = 1;
Console.Write(" " + vtor);
int sum = 0;

while (number >= sum)
{
    sum = perv + vtor;
    Console.Write(" " + sum);                
    perv = vtor;
    vtor = sum;                
}


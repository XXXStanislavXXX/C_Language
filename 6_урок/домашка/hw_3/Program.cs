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

Console.WriteLine("Your Fib Digit ");
int number = Convert.ToInt32(Console.ReadLine());

int first = 0;
Console.Write(" " + first);
int second = 1;
Console.Write(" " + second);
int sum = 0;

while (number >= sum)
{
    sum = first + second;
    Console.Write(" " + sum);                
    first = second;
    second = sum;                
}


/*
Задача - найти максимум из 9 чисел
*/

int a1 = 3;
int b1 = 10;
int c1 = 13;
int a2 = 94;
int b2 = 93;
int c2 = 38;
int a3 = 22;
int b3 = 77;
int c3 = 55;

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

// int Max1 = Max(a1, b1, c1);
// int Max2 = Max(a2, b2, c2);
// int Max3 = Max(a3, b3, c3);

// System.Console.WriteLine(Max1);
// System.Console.WriteLine(Max2);
// System.Console.WriteLine(Max3);

// System.Console.WriteLine(Max(Max1, Max2, Max3));

int Maximum = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3 ,c3)
    );

    System.Console.WriteLine(Maximum);



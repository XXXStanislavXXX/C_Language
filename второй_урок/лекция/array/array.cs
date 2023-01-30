/*
Задача - найти максимум из 9 чисел
*/

int[] array = {13, 42, 36, 44, 225, 646, 1237, 48, 12349};

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int Maximum = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
    );

    System.Console.WriteLine(Maximum);



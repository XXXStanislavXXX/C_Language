/*
Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда 
5 -> Пятница
*/

Console.WriteLine("Введите ваше число: ");

int chislo = Convert.ToInt32(Console.ReadLine());

if (chislo == 3)
{
Console.WriteLine("Среда");
}
    else if (chislo == 5)
    {
    Console.WriteLine("Пятница");
    }
        else
        {
          Console.WriteLine("Введено не верное число ");
        }

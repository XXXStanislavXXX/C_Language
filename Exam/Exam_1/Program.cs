

string [] UserArray = new string[NumFromConsole("Array size")];
StringKeyboard(UserArray);
Console.Clear();
System.Console.WriteLine("Start array: ");
System.Console.WriteLine(String.Join(" ", UserArray));
int size = CountOfValues (UserArray);
string [] resultArray = new string [size];
ThreeDigitsArray(UserArray);
System.Console.WriteLine();
System.Console.WriteLine("Array: ");
System.Console.WriteLine(String.Join(" ", resultArray));

Console.ReadKey();

int NumFromConsole(string userNumber)  //  input frm console
{
    Console.Write($"Input Number {userNumber}: ");
    int number = int.Parse(Console.ReadLine());
    return number;
}

void StringKeyboard(string [] elements)  //  fill array frm keypad
    int length = elements.Length;

    for (int i = 0; i < length; i++)
    {
        System.Console.WriteLine("Input number: ");
        elements[i] = Console.ReadLine();
    }
    return;
}

int CountOfValues (string [] array) // cont of elements
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        {
            if (array[i].Length <= 3)
                count++;
        }    
    }
    return count;
}

string [] ThreeDigitsArray (string [] array) //  more than 3 symbols in other array
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        {
            if (array[i].Length <= 3)
            {
                resultArray[j] = array[i];
                j++;
            }    
        }    
    }
    return resultArray;
}
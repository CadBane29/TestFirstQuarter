void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

string[] StringThreeArray(string[] array, int stringLength)
{
    int count = default;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= stringLength) count++;
    }

    string[] newArray = new string[count];
    for (int i = 0, k = 0; i < array.Length; i++)
    {
        if (array[i].Length <= stringLength) 
        {
            newArray[k] = array[i];
            k++;
        }
    }
    return newArray;
}

string[] StringSplitArray(string split)
{
    string[] stringArray = split.Split(',');
    return stringArray;
}

Console.WriteLine("Пользователь, введите значения через запятую: ");
string msg = Console.ReadLine()!;
string[] array = StringSplitArray(msg);
PrintArray(array);
int digit = 3;
string[] arrayLessThanThree = StringThreeArray(array, digit);
PrintArray(arrayLessThanThree);
string[] text(int length)
{
    string[] arr = new string[] { "hello", "2", "the", "world", ":-)" };

    return arr;
}

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)

    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

string[] NewText(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
            Console.Write($"{arr[i]} ");
    }

    return arr;
}

string[] arr1 = text(5);
PrintArray(arr1);
string[] result = NewText(arr1);

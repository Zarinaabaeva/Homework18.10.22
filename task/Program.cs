int length = 5;

string[] Text(int length)
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
    string[] newArr = new string[length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        newArr[i] = arr[i];
        Console.Write($"{newArr[i]} ");
    }

    return newArr;
}

string[] arr1 = Text(length);
PrintArray(arr1);
string[] result = NewText(arr1);

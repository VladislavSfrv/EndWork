string[] EnterArray(int n)
{
    string[] arr = new string[n];

    for (int i = 0; i < n; i++)
    {
        string temp = Console.ReadLine();
        arr[i] = temp;
    }
    return arr;
}

string[] ArrayElemLessThanThree(string[] arr)
{
    string[] newArray = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length >= 3) newArray[i] = arr[i];
    }
    return newArray;
}

void PrintStringArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if(i != arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine();
}

Console.Write("Введите количество элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите элементы массива через Enter: ");
string[] arr = EnterArray(n);
Console.WriteLine();

string[] newArr = ArrayElemLessThanThree(arr);
PrintStringArray(arr);
PrintStringArray(newArr);
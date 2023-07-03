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
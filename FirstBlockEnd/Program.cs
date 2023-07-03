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
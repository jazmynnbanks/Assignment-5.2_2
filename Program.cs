static void PrintNumbers(int n)
{
    if (n == 1)
    {
        Console.Write("1 ");
        return;
    }
    else
    {
        PrintNumbers(n - 1);
        Console.Write(n + " ");
        return;
    }
}

PrintNumbers(10);
int Fibonacсi(int num)
{
    if (num == 1)
        return 0;

    if (num == 2)
        return 1;

    return Fibonacсi(num - 1) + Fibonacсi(num - 2);
}

Console.WriteLine(Fibonacсi(11));
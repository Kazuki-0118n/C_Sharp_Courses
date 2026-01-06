int userNum;
bool parsed;

do
{
    Console.Write("Enter a positive number: ");
    parsed = int.TryParse(Console.ReadLine(), out userNum);

} while (!parsed || userNum <= 0);

int Fibonacсi(int num)
{
    if (num == 1)
        return 0;

    if (num == 2)
        return 1;

    return Fibonacсi(num - 1) + Fibonacсi(num - 2);
}

Console.WriteLine(Fibonacсi(userNum));
Random random = new Random();

int[,] yakiisMasiv = new int[5, 5];

for (int i = 0; i < 5; i++)           // рядки
{
    for (int j = 0; j < 5; j++)       // стовпці
    {
        yakiisMasiv[i, j] = random.Next(-100, 100);
        Console.Write(yakiisMasiv[i, j] + " ");
    }
    Console.WriteLine();
}


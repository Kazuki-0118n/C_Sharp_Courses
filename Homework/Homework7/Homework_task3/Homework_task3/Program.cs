int[,] table = new int[9, 9];

for (int i = 0; i < 9; i++)    
{
    for (int j = 0; j < 9; j++)   
    {
        table[i, j] = (i + 1) * (j + 1);
    }
}

// виведення результату множення
for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        Console.Write(table[i, j] + "\t");
    }
    Console.WriteLine();
}



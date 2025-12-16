Random random = new Random();
int[] randomMasive = new int[10];

// заповнення масиву
for (int i = 0; i < randomMasive.Length; i++)
{
    randomMasive[i] = random.Next(-10, 10);
}

// виведення елементів з парними індексами
for (int i = 0; i < randomMasive.Length; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(randomMasive[i]);
    }
}

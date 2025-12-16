Random random = new Random();

// створення масиву
int[] randomMasive = new int[10];

// змінна для суми
int numberSum = 0;


// заповнення масиву випадковими числами
for (int i = 0; i < randomMasive.Length; i++)
{
    randomMasive[i] = random.Next(-10, 10);
}


// виведення елементів з парними індексами
Console.WriteLine("Numbers with even index:");
for (int i = 0; i < randomMasive.Length; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(randomMasive[i]);
        numberSum += randomMasive[i];       //підрахунок суми
    }
}


// сума 
Console.WriteLine("Is the sum of the numbers a non-negative number?");

if (numberSum >= 0)
{
    Console.WriteLine("Yes. It's a non-negative number.");
}
else
{
    Console.WriteLine("No. It's a negative number.");
}

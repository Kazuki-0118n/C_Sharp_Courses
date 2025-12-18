// створення масиву
int[,] yakiisMasiv =
{
    { 99, 27, 3, 8, 10 },
    { 2, 1, 4, 67, 739 },
    { 9, 122, 11, 0, 7 },
    { 4, 455, 8, 12, 1 },
    { 6, 666, 81, 43, 5 }
};

int max = 0;
int min = 100000;

foreach(int num in yakiisMasiv)
{
    if (num > max)           // порівнює для знаходження найбільшого числа
    {
        max = num;
    }
    if (num < min)           // порівнює для знаходження найменшого числа
    {
        min = num;
    }
}

int targetMax = max;
int targetMin = min;

// найбільше число виведення
Console.WriteLine($"The largest number: {max}");

// -- знаходження координат найбільного числа
for (int i = 0; i < 5; i++)  // рядки
{
    for (int j = 0; j < 5; j++)  // стовпці 
    {
        if (yakiisMasiv[i, j] == targetMax)
        {
            Console.WriteLine($"Coordinates: [{i}, {j}]"); 
        }
    }
}

// найменше число виведення
Console.WriteLine($"The lowest number: {min}");

// -- знаходження координат найменшого числа
for (int i = 0; i < 5; i++)  // рядки
{
    for (int j = 0; j < 5; j++)  // стовпці 
    {
        if (yakiisMasiv[i, j] == targetMin)
        {
            Console.WriteLine($"Coordinates: [{i}, {j}]");
        }
    }
}
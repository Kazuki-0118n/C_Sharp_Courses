// створення масиву
int[,] yakiisMasiv =
{
    { 99, 27, 3, 8, 10 },
    { 2, 1, 4, 67, 739 },
    { 9, 122, 11, 0, 7 },
    { 4, 455, 8, 12, 1 },
    { 6, 666, 81, 43, 5 }
};

int max = yakiisMasiv[0, 0];
int min = yakiisMasiv[0, 0];

int maxRow = 0, maxCol = 0;
int minRow = 0, minCol = 0;

for (int i = 0; i < 5; i++)        // рядки
{
    for (int j = 0; j < 5; j++)    // стовпці
    {
        // пошук максимального
        if (yakiisMasiv[i, j] > max)
        {
            max = yakiisMasiv[i, j];
            maxRow = i;
            maxCol = j;
        }

        // пошук мінімального
        if (yakiisMasiv[i, j] < min)
        {
            min = yakiisMasiv[i, j];
            minRow = i;
            minCol = j;
        }
    }
}
// найбільше число виведення
Console.WriteLine($"The largest number: {max}");
Console.WriteLine($"Coordinates: [{maxRow}, {maxCol}].");

// найменше число виведення
Console.WriteLine($"The lowest number: {min}");
Console.WriteLine($"Coordinates: [{minRow}, {minCol}].");


Console.OutputEncoding = System.Text.Encoding.UTF8;  

// -- Ранок
Console.WriteLine("Введіть кількість ранкових годин:");
double morningHours;
while (!double.TryParse(Console.ReadLine(), out morningHours))   // перевірка на введення кількості годин
{
    Console.WriteLine("Помилка! Введіть число:");
}

Console.WriteLine("Введіть ранкову ставку:");
decimal morningRate;
while (!decimal.TryParse(Console.ReadLine(), out morningRate))   // перевірка на введення ранкової ставки
{
    Console.WriteLine("Помилка! Введіть число:");
}

// -- Обід
Console.WriteLine("Введіть кількість обідніх годин:");
double dayHours;
while (!double.TryParse(Console.ReadLine(), out dayHours))    
{
    Console.WriteLine("Помилка! Введіть число:");
}

Console.WriteLine("Введіть обідню ставку:");
decimal dayRate;
while (!decimal.TryParse(Console.ReadLine(), out dayRate))   
{
    Console.WriteLine("Помилка! Введіть число:");
}

// -- Вечір
Console.WriteLine("Введіть кількість вечірніх годин:");
double eveningHours;
while (!double.TryParse(Console.ReadLine(), out eveningHours))     
{
    Console.WriteLine("Помилка! Введіть число:");
}

Console.WriteLine("Введіть вечірню ставку:");
decimal eveningRate;
while (!decimal.TryParse(Console.ReadLine(), out eveningRate))
{
    Console.WriteLine("Помилка! Введіть число:");
}

// -- Розрахунок
decimal salary =                                               
    (decimal)morningHours * morningRate +
    (decimal)dayHours * dayRate +
    (decimal)eveningHours * eveningRate;

Console.WriteLine($"\nОплата за день: {salary}");
Console.ReadKey();
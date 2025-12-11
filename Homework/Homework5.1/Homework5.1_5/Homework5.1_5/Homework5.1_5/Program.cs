Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Введіть кількість робочих годин: ");    
double hours;

while (!double.TryParse(Console.ReadLine(), out hours))     // перевірка на введення робочих годин
{
    Console.WriteLine("Помилка! Введіть число:");
}

Console.WriteLine("Введіть ставку за годину: ");
decimal hourlyRate;

while (!decimal.TryParse(Console.ReadLine(), out hourlyRate))    // перевірка на введення годиної ставки
{
    Console.WriteLine("Помилка! Введіть число:");
}

decimal salary = (decimal)hours * hourlyRate;    // розрахунок оплати за день

Console.WriteLine($"Оплата за день: {salary}");
Console.ReadKey();

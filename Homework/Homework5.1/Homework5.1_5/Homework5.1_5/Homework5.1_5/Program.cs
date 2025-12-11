//Напишіть програму, яка запитує в користувача кількість годин,
//працюваних за день, та розмір годинної ставки. Після введення значень програма має обчислити та вивести оплату за день.
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Введіть кількість робочих годин: ");
double hours;

while (!double.TryParse(Console.ReadLine(), out hours))
{ 
Console.WriteLine("Помилка! Введіть число:")
}

Console.WriteLine("Введіть ставку за годину: ");
decimal hourlyRate;

while (!decimal.TryParse(Console.ReadLine(), out hourlyRate))
{
    Console.WriteLine("Помилка! Введіть число!")
}

decimal salary = hours * hourlyRate

Console.WriteLine($"Заробітна плата: {salary}");
Console.ReadKey();

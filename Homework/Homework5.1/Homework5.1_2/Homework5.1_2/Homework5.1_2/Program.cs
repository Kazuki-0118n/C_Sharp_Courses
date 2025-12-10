Console.OutputEncoding = System.Text.Encoding.UTF8;   // щоб було видно українську мову

Console.Write("Введіть ціле число: ");

int rows;

               // перевірка щоб користувач ввів число
while (!int.TryParse(Console.ReadLine(), out rows))
{
    Console.WriteLine("Помилка! Введіть ціле число:");
}

for (int i = 1; i <= rows; i++)       // цикл на кількість рядків
{
    for (int j = 1; j <= i; j++)      //  цикл на зірочки у рядках
    {
        Console.Write("✭");
    }
    Console.WriteLine();                
}

Console.OutputEncoding = System.Text.Encoding.UTF8;  // щоб було видно українську

Console.WriteLine("Введіть ціле число: ");

string strUserNumber = Console.ReadLine();       // запит числа від користувача
int userNumber = 0;

if (int.TryParse(strUserNumber, out userNumber))       
{
    Console.WriteLine($"Таблиця множення на {userNumber}");      

    for (int i = 1; i <= 10; i++)                                     // таблиця множення від 1 до 10 на число користувача
    {
        Console.WriteLine($"{userNumber} * {i} = {userNumber * i}");
    }
}
                             // якщо було введено не число
else
{
    Console.WriteLine("Не є числом!");
}

Console.ReadKey();   
Console.WriteLine("Enter a number: ");

string strUserNumber = Console.ReadLine();
int userNumber = 0;

// перевірка чи правильно введено
while (!int.TryParse(strUserNumber, out userNumber))
{
    Console.WriteLine("Помилка! Введіть число:");
    strUserNumber = Console.ReadLine();
}
Console.WriteLine($"prime numbers from 1 to {userNumber}:");

for (int i = 2; i <= userNumber; i++)   // цикл на усі числа
{
    bool isSimpleNumber = true;

    for (int j = 2; j < i; j++)   // цикл на перевірку дільників
    {
        if (i % j == 0)
        {
            isSimpleNumber = false;
        }
    }

    if (isSimpleNumber)
    {
        Console.Write(i + " ");   // виведення простих чисел
    }
}

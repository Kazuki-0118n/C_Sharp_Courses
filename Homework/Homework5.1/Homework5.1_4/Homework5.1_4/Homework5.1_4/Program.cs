using System; 
Console.OutputEncoding = System.Text.Encoding.UTF8; 

Console.WriteLine("Введіть кількість чисел Фібоначчі:");
int n;

// перевірка введення
while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
{
    Console.WriteLine("Помилка! Введіть додатне ціле число:");
}

int first = 0;   // перше число
int second = 1;  // друге число

Console.WriteLine("\nПослідовність Фібоначчі:");

for (int i = 1; i <= n; i++)
{
    Console.Write(first + " ");

    int next = first + second; // наступне число
    first = second;            // зсув значень
    second = next;
}

Console.ReadKey();

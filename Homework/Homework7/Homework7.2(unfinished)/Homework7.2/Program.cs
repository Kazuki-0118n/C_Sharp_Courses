using System;
Console.OutputEncoding = System.Text.Encoding.UTF8;

bool someoneWin = true;
char pleyerX = 'x';
char pleyerY = 'y';

char[,] game =
{
    { '1', '2', '3' },
    { '4', '5', '6' },
    { '7', '8', '9' }
};


//string firstPleyer = x;
//string secondPleyer = o;
char pleyerOne_Choose;
char pleyerTwo_Choose;


// -- Створення ігрового поля
for (int i = 0; i < 3; i++)
{ 
    for (int j = 0; j < 3; j++)
    {
        char field = game[i, j];
        Console.Write($"{field} | ");
    }
    Console.WriteLine();
    Console.WriteLine("----------.");
}

// перший хід
Console.WriteLine("Хід першого гравця.Введіть номер клітинки для ходу: ");
char input;
while (!char.TryParse(Console.ReadLine(), out input))
{
    Console.WriteLine("Введіть одне число: ");
}

char playerOne_Choose = input;

// виведення x у поле
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        if (game[i, j] == playerOne_Choose)
        {
            game[i, j] = pleyerX;
        }
    }
}

// оновлення поля
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        char field = game[i, j];
        Console.Write($"{field} | ");
    }
    Console.WriteLine();
    Console.WriteLine("----------.");
}

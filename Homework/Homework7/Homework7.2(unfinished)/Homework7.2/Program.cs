using System;
Console.OutputEncoding = System.Text.Encoding.UTF8;

//bool someoneWin = false;  
bool moveMade = false;
char pleyerX = 'x';
char pleyerY = 'y';

char[,] game =
{
    { '1', '2', '3' },
    { '4', '5', '6' },
    { '7', '8', '9' }
};

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
char inputOne;
while (!char.TryParse(Console.ReadLine(), out inputOne))
{
    Console.WriteLine("Введіть одне число: ");
}

char playerOne_Choose = inputOne;

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

char inputTwo = ' ';
// Другий хід
while (!moveMade)
{
    Console.WriteLine("Хід другого гравця.Введіть номер клітинки для ходу: ");
    while (!char.TryParse(Console.ReadLine(), out inputTwo))
    {
        Console.WriteLine("Введіть одне число: ");         // повторний ввод якщо користувач ввів не номер клітинки
    }
    // якщо номер введеної клитинки вже зайнятий
    if (inputTwo == inputOne)
    {
        Console.WriteLine("Ви не можете зробити хід поверх іншого гравця.");
        Console.WriteLine("Виберіть номер клітинки для ходу: ");
        // повернення на верх циклу
        continue;
    }
    moveMade = true;
}

char playerTwo_Choose = inputTwo;

// виведення x у поле
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        if (game[i, j] == playerTwo_Choose)
        {
            game[i, j] = pleyerY;
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
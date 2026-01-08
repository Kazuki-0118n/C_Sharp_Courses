using System;
Console.OutputEncoding = System.Text.Encoding.UTF8;

// символи гравців
char pleyerX = 'x';
char pleyerO = '0';

bool xWon = false;
bool oWon = false;


char[,] game =
{
    { '1', '2', '3' },
    { '4', '5', '6' },
    { '7', '8', '9' }
};

char pleyerOneMove;
char pleyerTwoMove;

Console.WriteLine("Гра: Хрестики-нолики!");

// -- Створення ігрового поля
void PrintBoard(char[,] game)
{
    for (int i = 0; i < game.GetLength(0); i++)
    {
        for (int j = 0; j < game.GetLength(1); j++)
        {
            char field = game[i, j];
            Console.Write($"{field} | ");
        }
        Console.WriteLine();
        Console.WriteLine("----------.");
    }
}


// -- Перше коло ходів
// перший хід x

char GetPlayerMoveX(char[,] game)
{
    char pleyerOneMove = ' ';
    do
    {
        Console.WriteLine("Хід першого гравця.Введіть номер клітинки для ходу: ");
    }
    while (!char.TryParse(Console.ReadLine(), out pleyerOneMove));
    {
        Console.WriteLine("Введіть одне число: ");
    }
    return pleyerOneMove;
}

char pleyerOne_Choose = GetPlayerMoveX(game);


////////////////////////////////////////


// виведення x у поле
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        if (game[i, j] == pleyerOne_Choose)
        {
            game[i, j] = pleyerX;   // замість числа який обрав користувач ставиться х
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

bool moveMade = false;
// перший хід o
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

// виведення o у поле
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        if (game[i, j] == playerTwo_Choose)
        {
            game[i, j] = pleyerO;   //  замість числа який обрав користувач ставиться о
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

bool moveIsMade = false;

// -- Друге коло ходів
// другий хід Х
while (!moveIsMade)
{
    Console.WriteLine("Хід першого гравця.Введіть номер клітинки для ходу: ");
    while (!char.TryParse(Console.ReadLine(), out inputOne))
    {
        Console.WriteLine("Введіть одне число: ");         // повторний ввод якщо користувач ввів не номер клітинки
    }
    // якщо номер введеної клитинки вже зайнятий
    if (inputOne == inputTwo)
    {
        Console.WriteLine("Ви не можете зробити хід поверх іншого гравця.");
        Console.WriteLine("Виберіть номер клітинки для ходу: ");
        // повернення на верх циклу
        continue;
    }
    moveIsMade = true;
}

playerOne_Choose = inputOne;  // щоб програма запа'ятала та вивела хід

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

bool hasMoved = false;
// другий хід o
while (!hasMoved)
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
    hasMoved = true;
}

playerTwo_Choose = inputTwo;   // щоб програма запа'ятала та вивела хід

// виведення o у поле
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        if (game[i, j] == playerTwo_Choose)
        {
            game[i, j] = pleyerO;
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


bool moveValid = false;
// -- Третє коло ходів
// третій хід Х
while (!moveValid)
{
    Console.WriteLine("Хід першого гравця.Введіть номер клітинки для ходу: ");
    while (!char.TryParse(Console.ReadLine(), out inputOne))
    {
        Console.WriteLine("Введіть одне число: ");         // повторний ввод якщо користувач ввів не номер клітинки
    }
    // якщо номер введеної клитинки вже зайнятий
    if (inputOne == inputTwo)
    {
        Console.WriteLine("Ви не можете зробити хід поверх іншого гравця.");
        Console.WriteLine("Виберіть номер клітинки для ходу: ");
        // повернення на верх циклу
        continue;
    }
    moveValid = true;
}

playerOne_Choose = inputOne;  // щоб програма запа'ятала та вивела хід

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
// -- Перевірка чи вийграв гравець 1
// рядки
for (int i = 0; i < 3; i++)
{
    if (game[i, 0] == 'x' &&
        game[i, 1] == 'x' &&
        game[i, 2] == 'x')
    {
        xWon = true;
    }
}
// стовпці
for (int j = 0; j < 3; j++)
{
    if (game[0, j] == 'x' &&
        game[1, j] == 'x' &&
        game[2, j] == 'x')
    {
        xWon = true;
    }
}
// діагоналі
if (game[0, 0] == 'x' &&
    game[1, 1] == 'x' &&
    game[2, 2] == 'x')
{
    xWon = true;
}

if (game[0, 2] == 'x' &&
    game[1, 1] == 'x' &&
    game[2, 0] == 'x')
{
    xWon = true;
}
if (xWon)
{
       Console.WriteLine("Перший гравець переміг!");
       return;  // завершення програми якщо гравець переміг
}

moveValid = false;
// третій хід o
while (!moveValid)
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
    moveValid = true;
}

playerTwo_Choose = inputTwo;   // щоб програма запа'ятала та вивела хід

// виведення o у поле
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        if (game[i, j] == playerTwo_Choose)
        {
            game[i, j] = pleyerO;
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


// -- Перевірка чи вийграв гравець 2
// рядки
for (int i = 0; i < 3; i++)
{
    if (game[i, 0] == 'o' &&
        game[i, 1] == 'o' &&
        game[i, 2] == 'o')
    {
        oWon = true;
    }
}
// стовпці
for (int j = 0; j < 3; j++)
{
    if (game[0, j] == 'o' &&
        game[1, j] == 'o' &&
        game[2, j] == 'o')
    {
        oWon = true;
    }
}
// діагоналі
if (game[0, 0] == 'o' &&
    game[1, 1] == 'o' &&
    game[2, 2] == 'o')
{
    oWon = true;
}

if (game[0, 2] == 'o' &&
    game[1, 1] == 'o' &&
    game[2, 0] == 'o')
{
    oWon = true;
}
if(oWon)
{
    Console.WriteLine("Другий гравець переміг!");
    return; // завершення програми якщо гравець переміг
}


bool moveIsValid = false;
// -- Четверте коло ходів
// четвертий хід Х
while (!moveIsValid)
{
    Console.WriteLine("Хід першого гравця.Введіть номер клітинки для ходу: ");
    while (!char.TryParse(Console.ReadLine(), out inputOne))
    {
        Console.WriteLine("Введіть одне число: ");         // повторний ввод якщо користувач ввів не номер клітинки
    }
    // якщо номер введеної клитинки вже зайнятий
    if (inputOne == inputTwo)
    {
        Console.WriteLine("Ви не можете зробити хід поверх іншого гравця.");
        Console.WriteLine("Виберіть номер клітинки для ходу: ");
        // повернення на верх циклу
        continue;
    }
    moveIsValid = true;
}

playerOne_Choose = inputOne;  // щоб програма запа'ятала та вивела хід

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

// -- Перевірка чи вийграв гравець 1
// рядки
for (int i = 0; i < 3; i++)
{
    if (game[i, 0] == 'x' &&
        game[i, 1] == 'x' &&
        game[i, 2] == 'x')
    {
        xWon = true;
    }
}
// стовпці
for (int j = 0; j < 3; j++)
{
    if (game[0, j] == 'x' &&
        game[1, j] == 'x' &&
        game[2, j] == 'x')
    {
        xWon = true;
    }
}
// діагоналі
if (game[0, 0] == 'x' &&
    game[1, 1] == 'x' &&
    game[2, 2] == 'x')
{
    xWon = true;
}

if (game[0, 2] == 'x' &&
    game[1, 1] == 'x' &&
    game[2, 0] == 'x')
{
    xWon = true;
}
if (xWon)
{
    Console.WriteLine("Перший гравець переміг!");
    return;  // завершення програми якщо гравець переміг
}

moveIsValid = false;

// четвертий хід o
while (!moveIsValid)
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
    moveIsValid = true;
}

playerTwo_Choose = inputTwo;   // щоб програма запа'ятала та вивела хід

// виведення o у поле
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        if (game[i, j] == playerTwo_Choose)
        {
            game[i, j] = pleyerO;
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


// -- Перевірка чи вийграв гравець 2
// рядки
for (int i = 0; i < 3; i++)
{
    if (game[i, 0] == 'o' &&
        game[i, 1] == 'o' &&
        game[i, 2] == 'o')
    {
        oWon = true;
    }
}
// стовпці
for (int j = 0; j < 3; j++)
{
    if (game[0, j] == 'o' &&
        game[1, j] == 'o' &&
        game[2, j] == 'o')
    {
        oWon = true;
    }
}
// діагоналі
if (game[0, 0] == 'o' &&
    game[1, 1] == 'o' &&
    game[2, 2] == 'o')
{
    oWon = true;
}

if (game[0, 2] == 'o' &&
    game[1, 1] == 'o' &&
    game[2, 0] == 'o')
{
    oWon = true;
}
if (oWon)
{
    Console.WriteLine("Другий гравець переміг!");
    return; // завершення програми якщо гравець переміг
}


bool isHasMoved = false;
// -- П'яте коло ходів
// п'ятий хід Х
while (!isHasMoved)
{
    Console.WriteLine("Хід першого гравця.Введіть номер клітинки для ходу: ");
    while (!char.TryParse(Console.ReadLine(), out inputOne))
    {
        Console.WriteLine("Введіть одне число: ");         // повторний ввод якщо користувач ввів не номер клітинки
    }
    // якщо номер введеної клитинки вже зайнятий
    if (inputOne == inputTwo)
    {
        Console.WriteLine("Ви не можете зробити хід поверх іншого гравця.");
        Console.WriteLine("Виберіть номер клітинки для ходу: ");
        // повернення на верх циклу
        continue;
    }
    isHasMoved = true;
}

playerOne_Choose = inputOne;  // щоб програма запа'ятала та вивела хід

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

// -- Перевірка чи вийграв гравець 1
// рядки
for (int i = 0; i < 3; i++)
{
    if (game[i, 0] == 'x' &&
        game[i, 1] == 'x' &&
        game[i, 2] == 'x')
    {
        xWon = true;
    }
}
// стовпці
for (int j = 0; j < 3; j++)
{
    if (game[0, j] == 'x' &&
        game[1, j] == 'x' &&
        game[2, j] == 'x')
    {
        xWon = true;
    }
}
// діагоналі
if (game[0, 0] == 'x' &&
    game[1, 1] == 'x' &&
    game[2, 2] == 'x')
{
    xWon = true;
}

if (game[0, 2] == 'x' &&
    game[1, 1] == 'x' &&
    game[2, 0] == 'x')
{
    xWon = true;
}
if (xWon)
{
    Console.WriteLine("Перший гравець переміг!");
    return;  // завершення програми якщо гравець переміг
}
else
{
    Console.WriteLine("Нічия!");
}
Console.ReadKey();

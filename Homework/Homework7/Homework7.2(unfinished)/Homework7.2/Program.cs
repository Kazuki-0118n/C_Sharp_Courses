using System;
Console.OutputEncoding = System.Text.Encoding.UTF8;
bool someoneWin = true;

int[,] game =
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};


//string firstPleyer = x;
//string secondPleyer = o;
int pleyerOne_Choose;
int pleyerTwo_Choose;


// -- Створення ігрового поля
for (int i = 0; i < 3; i++)
{ 
    for (int j = 0; j < 3; j++)
    {
        Console.Write(game[i, j] + " | ");
    }
    Console.WriteLine();
    Console.WriteLine("----------.");

};

Console.WriteLine("Хід першого гравця. Оберіть число для ходу:");
pleyerOne_Choose = int.TryParse(Console.ReadLine());
using System;
Console.OutputEncoding = System.Text.Encoding.UTF8;

int[,] game =
{
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};


//var firstPleyer = x;
//var secondPleyer = o;

// -- Створення ігрового поля
for (int i = 0; i < 3; i++)
{ 
    for (int j = 0; j < 3; j++)
    {
        Console.Write(game[i, j] + " | ");
    }
    Console.WriteLine();
    Console.WriteLine("----------.");
}



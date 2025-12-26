using System;
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Введіть ваше ім'я:");
string userFirstName  = Console.ReadLine();

Console.WriteLine("Введіть ваше прізвище:");
string userLastName = Console.ReadLine();

if (userFirstName[0] == userLastName[0])
{
    Console.WriteLine("Прізвище починається на ту ж літеру, що і ім’я");
}
else
{
    Console.WriteLine("Прізвище не починається на ту ж літеру, що і ім’я");
}    



using System;
using System.Text;
Console.OutputEncoding = System.Text.Encoding.UTF8;

StringBuilder report = new StringBuilder("ЗВІТ\nРЕЗУЛЬТАТ ЧИТАННЯ МАНГИ.");

// дадання дати
string dateReport = "\nДата:";
report.Append(dateReport);

Console.WriteLine("Дата прочитання останьої глави:");
string date = Console.ReadLine();
string paddedDate = date.PadLeft(15);
report.Append(paddedDate);


// додавання подій
bool isAdds = true;
const string EVENTS_OVER = "exit";
int eventsNum = 1;

while (isAdds)
{
    Console.WriteLine("Введіть подію, якщо події закінчились введіть 'exit': ");
    var userEvents = Console.ReadLine();
    if (userEvents == EVENTS_OVER)
    {
        isAdds = false;       // вихід з введення подій

    }
    else
    {
        string events = $"\nПодія {eventsNum}:  {userEvents}";
        report.AppendLine(events);
        eventsNum ++;
    }
}


Console.WriteLine(report.ToString());

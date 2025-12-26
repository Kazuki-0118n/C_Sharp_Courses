using System;
using System.Text;
Console.OutputEncoding = System.Text.Encoding.UTF8;

StringBuilder report = new StringBuilder("ЗВІТ\nРЕЗУЛЬТАТ ЧИТАННЯ МАНГИ.");

// дадання дати
string dateReport = "\nДата прочитання останьої глави:";
report.Append(dateReport);

Console.WriteLine("Дата прочитання останьої глави:");
string date = Console.ReadLine();
string paddedDate = date.PadLeft(15);
report.Append(paddedDate);



Console.WriteLine(report.ToString());

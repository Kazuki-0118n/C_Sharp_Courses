using System;
using System.IO;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.InputEncoding = System.Text.Encoding.UTF8;

string sourcePath = @"D:\Users\user\RunScript\VasyaSpeed.txt";
string destinationPath = @"D:\Users\user\RunScript\AnyutkaSpeed.txt";

// перевірка чи є файл
if (!File.Exists(sourcePath))
{
    Console.WriteLine($"Помилка! Файл за шляхом {sourcePath} не знайдено.");
    return;
}

try
{
    // Отримання інформації про файл
    FileInfo fileInfo = new FileInfo(sourcePath);
    Console.WriteLine("Інформація про вихідний файл:");
    Console.WriteLine($"- Повний шлях: {fileInfo.FullName}");
    // 1024.0 * 1024.0 перевення байтів у мегабайти; F2 кількість знаків після коми
    Console.WriteLine($"- Розмір: {fileInfo.Length / (1024.0 * 1024.0):F2} МБ");    
    Console.WriteLine($"- Останнє оновлення: {fileInfo.LastWriteTime}");
    Console.WriteLine("-----------------------------------------");


    using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
    using (FileStream destStream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write))
    {
        byte[] buffer = new byte[1024 * 1024];
        int bytesRead;

        Console.WriteLine("Починається копіювання зачекайте.");

        while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
        {
            destStream.Write(buffer, 0, bytesRead);
        }
    }

    Console.WriteLine("Файл успішно скопійовано!");
}
catch (UnauthorizedAccessException)
{
    Console.WriteLine("Помилка! Відмовлено у доступі до файлу.");
}
catch (IOException ex)
{
    Console.WriteLine($"Помилка при роботі з файлом: {ex.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Сталася непередбачена помилка: {ex.Message}");
}

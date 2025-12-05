using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8; //для української мови


string day = "";

Console.WriteLine("Введіть число від 1 до 7: ");
int number = int.Parse(Console.ReadLine());


switch (number)  //вводить номер дня тиждя - отримує день в результаті
{
    case 1:
         day = "Понеділок";
         break;
    case 2:
        day = "Вівторок";
        break;
    case 3:
        day = "Середа";
        break;
    case 4:
        day = "Четверг";
        break;
    case 5:
        day = "П'ятниця";
        break;
    case 6:
        day = "Субота";
        break;
    case 7:
        day = "Неділя";
        break;
    // всі інші випадки
    default:
        day = "Не є числом від 1 до 7";
    break;

}

Console.WriteLine(day);

Console.WriteLine("Enter the number of days: ");

string strDayNum = Console.ReadLine();
int intDayNum;

// Перевірка що введено саме ціле число
while (!int.TryParse(strDayNum, out intDayNum))
{
    Console.WriteLine("Error! Please, try again: ");
    strDayNum = Console.ReadLine();
}

// Перевірка що число > 0 
if (intDayNum <= 0)
{
    Console.WriteLine("The number must be greater than 0");
    return; // зупинка програми
}

int dayIndex = (intDayNum - 1) % 7 + 1;

// перетворення числа 1-7 у відповідний елемент enum
WeekDays dayWeek = (WeekDays)dayIndex;

Console.WriteLine($"Day after {intDayNum} days from Monday: {dayWeek}");


enum WeekDays
{
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,
    Thursday = 4,
    Friday = 5,
    Saturday = 6,
    Sunday = 7
}

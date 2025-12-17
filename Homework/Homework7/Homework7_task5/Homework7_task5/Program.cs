//*5. За допомогою enum створити програму,
//що буде запитувати у користувача кількість днів, а потім рахувати
//який буде день через введену кількість, якщо рахувати від понеділка і виводити результат.

Console.WriteLine("Enter the number of days: ");

var strDayNum = Console.ReadLine();
int intDayNum = 0;

while (!int.TryParse(strDayNum, out intDayNum))    // введення кількості днів
{
    Console.WriteLine("Error! Please, try again: ");
        strDayNum = Console.ReadLine();
}
if (intDayNum <= 0)
{ Console.WriteLine("The number must be greater than 0"); }


WeekDays day = (WeekDays)intDayNum;

// якщо введене число 1-7
if (intDayNum <= 7)             
{
    Console.WriteLine($"{day}");

}
else                                          
    for (int i = 1; i <= intDayNum; i++)
    {

    }




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
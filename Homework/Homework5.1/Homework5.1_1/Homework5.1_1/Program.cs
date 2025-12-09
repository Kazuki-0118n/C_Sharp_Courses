Console.OutputEncoding = System.Text.Encoding.UTF8; // введення української

const string EXIT_TEXT = "exit";      // вихід коли користувач ввів усі дані

bool ra = true;

int totalSalary = 0;        // сума всіх зарплат int workersCount = 0;
int workersCount = 0;       // лічильник працівників// лічильник працівників

do
{
    // введення зарплати працівників
    Console.WriteLine("Введіть зарплату працівника");
    Console.WriteLine("Якщо працівників більше немає введіть 'exit'\n");

    var strWorkersSalary = Console.ReadLine();
    int intWorkersSalary = 0;

    if (int.TryParse(strWorkersSalary, out intWorkersSalary))
    { totalSalary += intWorkersSalary;
      workersCount++;
    }
    else if (strWorkersSalary == "exit")
        ra = false;
    else
        Console.WriteLine("Помилка, введіть число!");
}
while (ra);
if (workersCount > 0)
{
    double average = totalSalary / workersCount;
    Console.WriteLine($"\nСередня зарплата: {average}");
}
else
{
    Console.WriteLine("\nНе введено жодної інформації про працівників.");
}

Console.ReadKey();  
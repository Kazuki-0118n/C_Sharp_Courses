/*Додавання справи: Напишіть функцію, яка додає нову справу до списку. Користувач повинен мати можливість ввести назву справи.
Виведення всіх справ: Реалізуйте функцію, яка виводить на екран усі справи зі списку.
Відмітка про виконання: Додайте можливість позначити справу як виконану. Користувач повинен ввести номер справи, яку він хоче відмітити.
Видалення справи: Напишіть функцію, яка дозволяє видалити справу зі списку. Користувач повинен ввести номер справи для видалення.
*/
using System;

string[] tasks = new string[10];
bool[] completed = new bool[10];
int count = 0;

bool statusChosen = false;
bool inputFinished = false;


PrintTasks(tasks, completed, statusChosen, inputFinished, count);
AddTasks(ref tasks, ref completed, ref count);


bool isRunning = true;
while (isRunning)
{
    PrintTasks(tasks, completed, statusChosen, inputFinished, count);

    Console.WriteLine();
    Console.WriteLine("1 - Mark task as completed");
    Console.WriteLine("2 - Delete task");
    Console.WriteLine("3 - Exit");
    Console.Write("Choose option: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            MarkTask(completed, count);
            statusChosen = true;
            break;

        case "2":
            DeleteTask(ref tasks, ref completed, ref count);
            break;

        case "3":
            isRunning = false;
            break;

        default:
            Console.WriteLine("Invalid choice.");
            Console.ReadKey();
            break;
    }

    PrintTasks(tasks, completed, statusChosen, inputFinished, count);

}

// methods
void AddTasks(ref string[]tasks,
    ref bool[]completed,
    ref int count)
{
    const string ANDED = "anded";
    bool isAdded = true;
    while (isAdded)
    {
        Console.WriteLine(@"Enter a task. If there are no more tasks, enter ""anded"":");
        var input = Console.ReadLine();

        if (input == "anded")
        {
            isAdded = false;
            break;
        }

        if (count == tasks.Length)
        {
            string[] newTasks = new string[tasks.Length + 10];
            bool[] newCompleted = new bool[completed.Length + 10];

            for (int i = 0; i < tasks.Length; i++)
            {
                newTasks[i] = tasks[i];
                newCompleted[i] = completed[i];
            }

            tasks = newTasks;
            completed = newCompleted;
        }

        tasks[count] = input;
        completed[count] = false;
        count++;
    }
}


void PrintTasks(string[] tasks,
    bool[] completed,
    bool statusChosen,
    bool inputFinished,
    int count)
{ 
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("TO-DO LIST:");
    Console.ResetColor();
    for (int i = 0; i < tasks.Length; i++)
    {
        if (tasks[i] == null)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Task {i + 1}:");
        }
        else if (!statusChosen)
        {
            // when the user has not yet chosen a status
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"Task {i + 1}: {tasks[i]}");
        }
        else if (completed[i])
        {
            // completed
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Task {i + 1}: {tasks[i]}");
        }
        else
        {
            // uncompleted
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Task {i + 1}: {tasks[i]}");
        }

        Console.ResetColor();
    }
}


void MarkTask(bool[] completed,
    int count)
{
    Console.Write("Enter task number: ");
    int number;
    var parsed = int.TryParse(Console.ReadLine(),out number);

    if (number < 1 || number > count)
    {
        Console.WriteLine("Invalid task number.");
        Console.ReadKey();
        return;
    }

    completed[number - 1] = true;
}


void DeleteTask(ref string[] tasks,
    ref bool[] completed,
    ref int count)
{
    Console.Write("Enter task number: ");
    int number;
    var parsed = int.TryParse(Console.ReadLine(), out number);

    if (number < 1 || number > count)
    {
        Console.WriteLine("Invalid task number.");
        Console.ReadKey();
        return;
    }

    for (int i = number - 1; i < count - 1; i++)
    {
        tasks[i] = tasks[i + 1];
        completed[i] = completed[i + 1];
    }

    tasks[count - 1] = null;
    completed[count - 1] = false;
    count--;
}
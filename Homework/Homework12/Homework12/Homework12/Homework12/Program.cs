/*Додавання справи: Напишіть функцію, яка додає нову справу до списку. Користувач повинен мати можливість ввести назву справи.
Виведення всіх справ: Реалізуйте функцію, яка виводить на екран усі справи зі списку.
Відмітка про виконання: Додайте можливість позначити справу як виконану. Користувач повинен ввести номер справи, яку він хоче відмітити.
Видалення справи: Напишіть функцію, яка дозволяє видалити справу зі списку. Користувач повинен ввести номер справи для видалення.
*/
using System;


string[] tasks = new string[10];
bool[] completed = new bool[10];
int count = 0;


//-///-///-///-///-
bool isRunning = true;
while (isRunning)
{

}

///////////////////////////////////////

void AddTasks(ref string[]tasks, ref bool[]completed, ref int count)
{
    const string ANDED = "anded";
    bool isAdded = false;
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


void PrintTasks(string[] tasks, bool[] completed, int count)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("TO-DO LIST:");
    Console.ResetColor();

    if (count == 0)
    {
        Console.WriteLine("No tasks.");
        return;
    }

    for (int i = 0; i < count; i++)
    {
        if (completed[i])
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        Console.WriteLine($"Task {i + 1}: {tasks[i]}");
        Console.ResetColor();
    }
}



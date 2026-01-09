/*Додавання справи: Напишіть функцію, яка додає нову справу до списку. Користувач повинен мати можливість ввести назву справи.
Виведення всіх справ: Реалізуйте функцію, яка виводить на екран усі справи зі списку.
Відмітка про виконання: Додайте можливість позначити справу як виконану. Користувач повинен ввести номер справи, яку він хоче відмітити.
Видалення справи: Напишіть функцію, яка дозволяє видалити справу зі списку. Користувач повинен ввести номер справи для видалення.
*/

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("TO-DO LIST:");
Console.ResetColor();

string[] defoultList = new string[] { "Task 1: ", "Task 2: ", "Task 3: ", "Task 4: ", "Task 5: ",
    "Task 6: ", "Task 7: ", "Task 8: ", "Task 9: ", "Task 10:" };

foreach (string task in defoultList)
{
    Console.WriteLine(task);
}

bool isAdded = true;
const string ANDED = "anded";   // when user enter all task 
int count = 0;
int numberTask = 1;

while (isAdded)
{
    Console.WriteLine(@"Enter a task. If there are no more tasks, enter ""anded"":");
    var input = Console.ReadLine();

    if (input == "anded")
    {
        isAdded = false;
        break;
    }

    if (count == defoultList.Length)
    {
        string[] newArray = new string [defoultList.Length + 10];

        for (int i = 0; i < defoultList.Length; i++)
        {
            newArray[i] = defoultList[i];
        }
        defoultList = newArray;
    }

    defoultList[count] = $"Task {numberTask}: " + input;
    count++;
    numberTask++;
}

for (int i = 0; i < count; i++)
{
    Console.WriteLine(defoultList[i]);
}

Console.WriteLine();
Console.WriteLine("If you want to highlight completed tasks, enter 1. If you want to highlight unfinished tasks, enter 2.");
Console.WriteLine("If you want to skip, enter 3:");
var userChoise = Console.ReadLine();

switch(userChoise)
{
    case "1":


        break;

    case "2":


        break;

    case "3":


        break;

    default:
        Console.WriteLine("Invalid choice. Please enter 1, 2, or 3.");
        break;
}
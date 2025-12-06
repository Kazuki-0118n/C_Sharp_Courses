using System.Text;

Console.OutputEncoding = System.Text.Encoding.UTF8;  // Відображення української мови


// Введення першого числа
Console.WriteLine("Введіть перше число(дробове через ','): ");
string input1 = Console.ReadLine();

// Перевірка правильності вводу
double firstNum;
if (!double.TryParse(input1, out firstNum))
{
    Console.WriteLine("Некоректні дані.");
    return; // зупинка програми
}

// Введення дії
Console.WriteLine("Введіть дію (+, -, *, /): ");
string op = Console.ReadLine();

if (               // Перевірка коректності операції
    op != "+"
    && op != "-"
    && op != "*"
    && op != "/"
   )
{
    Console.WriteLine("Некоректна дія!");
    return;
}


// Введення першого числа
Console.WriteLine("Введіть друге число(дробове через ','): ");
string input2 = Console.ReadLine();

// Перевірка правильності вводу
double secondNum;
if (!double.TryParse(input2, out secondNum))
{
    Console.WriteLine("Некоректні дані.");
    return; // зупинка програми
}


double result = 0;


switch (op)
{
    case "+":
        result = firstNum + secondNum;   //додавання
        break;
    case "-":
        result = firstNum - secondNum;   //віднімання
        break;
    case "*":
        result = firstNum * secondNum;
        break;
    case "/":
        // Перевірка ділення на нуль
        if (secondNum == 0)
        {
            Console.WriteLine("Помилка, ділення на нуль");
            return;
        }
        // якщо ділення на нуль нема
        result = firstNum / secondNum;
        break;
}

Console.WriteLine(result);

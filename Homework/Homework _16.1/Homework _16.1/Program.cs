double firstNum;
double secondNum;
double result = 0;

Console.Write("Enter first number: ");
while (!double.TryParse(Console.ReadLine(), out firstNum))
{
    Console.Write("Error! Enter a number: ");
}

Console.Write("Enter second number: ");
while (!double.TryParse(Console.ReadLine(), out secondNum))
{
    Console.Write("Error! Enter a number: ");
}

bool success = false;

try
{
    result = firstNum / secondNum;
    success = true;
}
catch (DivideByZeroException)
{
    Console.WriteLine("You can't divide by zero!");
}
catch (Exception)
{
    Console.WriteLine("Error in calculation.");
}
finally
{
    if (success)
    {
        Console.WriteLine($"The result is: {result}");
    }
    else
    {
        Console.WriteLine("Calculation failed, so no result to show.");
    }
}

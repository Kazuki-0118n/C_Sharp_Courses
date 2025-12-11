Console.WriteLine("Enter a number: ");
int userNumber = 0;

while (!int.TryParse(Console.ReadLine(), out userNumber))
{
    Console.WriteLine("Error! Enter a number: ");
}
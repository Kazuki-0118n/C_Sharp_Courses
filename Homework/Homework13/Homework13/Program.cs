using Homework13;

Account myAccount = new Account();

Console.WriteLine("Enter amount:");

if (decimal.TryParse(Console.ReadLine(), out decimal userInput))
{
    myAccount.Withdrawal(userInput);
}
else
{
    Console.WriteLine("Invalid input!");
}
using Homework13;

Account myAccount = new Account();

bool isRunning = true;

while (isRunning)
{
    Console.WriteLine("--- ACCOUNT MENU ---");
    Console.WriteLine("1 - View Balance");
    Console.WriteLine("2 - Withdraw");
    Console.WriteLine("3 - Deposit");
    Console.WriteLine("4 - Change Name");
    Console.WriteLine("5 - Exit");
    Console.Write("\nSelect an option: ");

    string input = Console.ReadLine();

    switch (input)
    {
        case "2":
            Console.WriteLine("Enter amount:");
            if (decimal.TryParse(Console.ReadLine(), out decimal userInputWithdr))
            {
                myAccount.Withdrawal(userInputWithdr);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            break;

        case "3":
            Console.WriteLine("Enter amount:");
            if (decimal.TryParse(Console.ReadLine(), out decimal userInputDepo))
            {
                myAccount.Deposit(userInputDepo);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            break;
            break;
    }
}
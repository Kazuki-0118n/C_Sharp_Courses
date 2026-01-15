using Homework13;

Account myAccount = new Account();

bool isRunning = true;

while (isRunning)
{
    Console.Clear();

    Console.WriteLine("--- ACCOUNT MENU ---");
    Console.WriteLine($"Account name: {myAccount.Name}");
    Console.WriteLine("1 - View Balance");
    Console.WriteLine("2 - Withdraw");
    Console.WriteLine("3 - Deposit");
    Console.WriteLine("4 - Change Name");
    Console.WriteLine("5 - Exit");
    Console.Write("\nSelect an option: ");

    string input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.WriteLine($"Current balance: {myAccount.Balance}");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
            break;

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

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
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

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
            break;

        case "4":
            Console.Write("\nEnter a new name: ");
            var newUserName = Console.ReadLine();
            myAccount.Name = newUserName;

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
            break;

        case "5":
            isRunning = false;
            break;

        default:
            Console.WriteLine("Invalid input!");

            Console.WriteLine("\nPress any key to return to menu...");
            Console.ReadKey();
            break;
    }
}
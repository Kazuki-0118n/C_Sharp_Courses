var keepRunning = true;
const string AND_PROG = "exit";

// -- Введення числа або вихід

while (keepRunning)
{
    Console.WriteLine("Enter a number or print 'exit': ");
    string strUserNumber = Console.ReadLine();

    // вихід з циклу
    if (strUserNumber == AND_PROG)
    {
        keepRunning = false;
    }
    else
    {
        int userNumber;

        while (!int.TryParse(strUserNumber, out userNumber))    //перевірка чи введено число
        {
            Console.WriteLine("Error! Enter a number: ");
        }
        if (strUserNumber == AND_PROG)
        {
            keepRunning = false;
        }



        // -- Перевірка чи є простим
        if (keepRunning)
        {
            bool isPrime = true;

            if (userNumber < 2)   // якщо менше 2 не просте
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i < userNumber; i++)   // знаходження дільників
                {
                    if (userNumber % i == 0)
                    {
                        isPrime = false;
                        break;   // всередині перевірки
                    }
                }
            }

            // виведення результату
            if (isPrime)
                Console.WriteLine($"{userNumber} is a prime number.");
            else
                Console.WriteLine($"{userNumber} is not a prime number.");
        }
    }
}

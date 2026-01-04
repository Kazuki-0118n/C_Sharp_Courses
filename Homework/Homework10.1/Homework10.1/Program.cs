int numberOfAttempts = 5;
Console.WriteLine($"Welcome! Try to guess the hidden word!"); //Number of letters in the word: 5\nNumber of allowed incorrect attempts: {numberOfAttempts}");
Console.WriteLine("Select mode:\n1 — easy, 2 — medium, 3 — hard");
char userSelectMode = ' ';
bool isValid = false;

while(!isValid)
{
    bool parsed = char.TryParse(Console.ReadLine(), out userSelectMode);

    // якщо це не один символ
    if (!parsed)
    {
        Console.WriteLine("Enter only one character!");
    }
    // якщо символ, але не 1, 2, 3
    else if (userSelectMode != '1' && userSelectMode != '2' && userSelectMode != '3')
    {
        Console.WriteLine("Enter a number from 1 to 3!");
    }
    
    else
    {
        isValid = true;
    }
}

string encryptedWord = "magic";
char[] guessedWord = { ' ', ' ', ' ', ' ', ' ' };


while ( numberOfAttempts > 0 )
{
    Console.Write("Enter a letter: ");
    char userLetter = ' ';
    while (!char.TryParse(Console.ReadLine(), out userLetter))
    {
        Console.WriteLine("Enter one letter!");
    }

    int index = encryptedWord.IndexOf(userLetter);

    if (index != -1)
    {
        Console.WriteLine($"This letter is in the word! Letter position: {index + 1}");

        // додає літеру у масив
        bool found = false;

        for (int i = 0; i < encryptedWord.Length; i++)
        {
            if (encryptedWord[i] == userLetter)
            {
                guessedWord[i] = userLetter;
                found = true;
            }
        }
        // перевірка вийграшу
        int openedLetters = 0;

        for (int i = 0; i < guessedWord.Length; i++)
        {
            if (guessedWord[i] != ' ')
            {
                openedLetters++;
            }
        }

        if (openedLetters == guessedWord.Length)
        {
            Console.WriteLine();
            Console.WriteLine($"Congratulations, you guessed the word! Hidden word: {encryptedWord}");
            Console.WriteLine("Thank you for playing.");
            break;
        }
    }
    else
    {
        numberOfAttempts--;
        Console.WriteLine($"There is no such letter! Remaining attempts: {numberOfAttempts}");
    }

}

if (numberOfAttempts == 0)
{
    Console.WriteLine();
    Console.WriteLine($"You lost! The hidden word was: {encryptedWord}");
    Console.WriteLine("Thank you for playing.");
}
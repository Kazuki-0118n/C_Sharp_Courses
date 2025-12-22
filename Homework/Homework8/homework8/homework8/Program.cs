//Написати програму, що знаходить другий найбільший елемент масиву.
//Написати програму, що буде сортувати за зростанням елементи двовимірного масиву.
//Написати програму, що буде видаляти з масиву елемент за вказаним індексом.
//Написати програму, що буде знаходити суму елементів по діагоналі у двовимірному масиві.

// -- Другий найбільший елемент
int[] firstArray = new int[] { 2, 3, 1, 7, 8, 4 };

for (int i = 0; i < firstArray.Length; i++)
    for(int j = 0; j < firstArray.Length; j++)
    {
        if ( j < firstArray.Length - 1 )
        {
            if (firstArray[j] > firstArray[j + 1])
            {
                int num = firstArray[j];
                firstArray[j] = firstArray[j + 1];
                firstArray[j + 1] = num;
            }
        }
    }

foreach(int ch in firstArray)
    Console.WriteLine(ch);

Console.WriteLine();
Console.WriteLine("Другий найбільший елемент:");
Console.WriteLine(firstArray[firstArray.Length - 2]);
Console.WriteLine();

//
// -- Сортування за зростанням
int[,] secondArray =
{
    { 1, 12, 2, 23 },
    { 4, 43, 3, 87 },
    { 5, 9, 82, 3 }
};

for (int numArray = 0; numArray < secondArray.GetLength(1) - 1; numArray++)
    for (int i = 0; i < secondArray.GetLength(0); i++)     
    {
        for (int j = 0; j < secondArray.GetLength(1) - 1; j++)
        {
            if (secondArray[i, j] > secondArray[i, j + 1])
            {
                int numb = secondArray[i, j];
                secondArray[i, j] = secondArray[i, j + 1];
                secondArray[i, j + 1] = numb;
            }
        }
    }

// виведення масиву у вигляді таблиці
for (int row = 0; row < secondArray.GetLength(0); row++)
{
    for (int col = 0; col < secondArray.GetLength(1); col++)
    {
        Console.Write(secondArray[row, col] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine();


//
// -- Видалення елементу за індексом
int[] thirdArray = new int[] { 2, 55, 6, 234, 7, 2, 8, 9};

foreach(int i in thirdArray)
    Console.Write(i + "  ");

int userNum =  -1;
bool isValid = false;

// зчитування та перевірка вводу
while (!isValid)
{
    Console.WriteLine("Оберіть індекс числа для видалення(0-7):"); 

    if (!int.TryParse(Console.ReadLine(), out userNum))
    {
        Console.WriteLine("Не є числом.");
    }
    else if (userNum < 0 || userNum >= 8)
    {
        Console.WriteLine("Індекс повинен бути від 0 до 7.");
    }
    else
    {
        isValid = true;
    }
}


// створення нового масиву з видаленим числом
int[] newArray = new int[thirdArray.Length - 1];

int newIndex = 0;

for (int i = 0; i < thirdArray.Length; i++)
{
    if (i != userNum)
    {
        newArray[newIndex] = thirdArray[i];
        newIndex++;
    }
}

// виведення нового масиву
Console.WriteLine();
foreach (int i in newArray)
{
    Console.Write(i + "  ");
}
// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого четная.
// Пример
// 5 12 16 q [STOP]
// 3 45 342 15 [STOP]

int getSumDigitsOfNumber(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

bool checkNumberForEven(int sum)
{
    bool numberIsEven = false;
    if (sum % 2 == 0)
    {
        numberIsEven = true;
    }
    return numberIsEven;
}

while (true)
{
    Console.Write("Введите целое цисло: ");
    string text = Console.ReadLine();
    if (text == "q")
    {
        break;
    }
    int number;
    if (int.TryParse(text, out number))
    {
        if (checkNumberForEven(getSumDigitsOfNumber(number)))
        {
            break;
        }
    }
}
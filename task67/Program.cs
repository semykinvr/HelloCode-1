// Задача 67: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

// функция ввода числа с клавиатуры
int InputNumber(string message)
{
    System.Console.Write(message);
    string? input = Console.ReadLine();
    int number;
    bool checkInput = int.TryParse(input, out number);
    while (!checkInput)
    {
        System.Console.Write(message);
        input = Console.ReadLine();
        checkInput = int.TryParse(input, out number);
    }
    return number;
}

int m = InputNumber("Введите M: ");
int n = InputNumber("Введите N: ");

if (m <= n)
    for (int i = m; i <= n; i++)
        Console.Write(i + ", ");


if (m > n)
    for (int i = m; i >= n; i--)
        Console.Write(i + ", ");

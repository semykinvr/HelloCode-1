// Задача 69: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 15
// M = 4; N = 8. -> 5

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
int summa = 0;

if (m <= n)
    for (int i = m; i <= n; i++)
        summa = summa + i;

if (m > n)
    for (int i = m; i >= n; i--)
        summa = summa + i;

Console.WriteLine("Сумма: " + summa);


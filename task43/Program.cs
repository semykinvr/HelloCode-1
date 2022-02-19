// 43. Написать программу преобразования десятичного числа в двоичное

// функция ввода числа с консоли
int InputNumber(string message)
{
    Console.Write(message);
    string? input = Console.ReadLine();
    int.TryParse(input, out int number);
    //return Convert.ToInt32(input);
    return number;
}

int N = InputNumber("Введите число: ");
Console.WriteLine("Вы ввели десятичное " + N);
string S = Convert.ToString(N, 2);
Console.WriteLine("В двоичном виде это (string вариант1): " + S);
S = Convert.ToString(N, 2).PadLeft(8, '0');
Console.WriteLine("В двоичном виде это (string вариант2): " + S);

// 21. Программа проверяет пятизначное число на палиндромом.

// функция ввода числа с консоли
int InputNumber(string message)
{
    Console.Write(message);
    string? input = Console.ReadLine();
    return Convert.ToInt32(input);
}

int n = InputNumber("Введите пятизначное число: ");
Console.WriteLine("Вы ввели: " + n);

// Console.WriteLine("n % 10: " + n % 10);
// Console.WriteLine("n / 10000: " + n / 10000);
// Console.WriteLine("(n / 10) % 10: " + (n / 10) % 10);
// Console.WriteLine("(n / 1000) % 10: " + (n / 1000) % 10);

bool v1 = n % 10 == n / 10000;
bool v2 = (n / 10) % 10 == (n / 1000) % 10;

if (v1 && v2) Console.WriteLine("полиндром");
else Console.WriteLine("НЕ полиндром");
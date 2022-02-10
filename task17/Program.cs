// 17. По двум заданным числам проверять является ли одно квадратом другого

// функция ввода числа с консоли
int InputNumber(string message)
{
    Console.Write(message);
    string? input = Console.ReadLine();
    return Convert.ToInt32(input);
    //return int.Parse(input);
}

int n1 = InputNumber("Введите первое число: ");
int n2 = InputNumber("Введите второе число: ");

if (n1 == n2 * n2 || n2 == n1 * n1) Console.WriteLine("Одно число является квадратом другого");
else Console.WriteLine("числа не являются квадратом друг друга");
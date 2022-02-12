// 29. Написать программу вычисления произведения чисел от 1 до N

// функция ввода числа с консоли
int InputNumber(string message)
{
    Console.Write(message);
    string? input = Console.ReadLine();
    return Convert.ToInt32(input);
}

int N = InputNumber("Введите число: "); 
int multiply = 1;
for (int i = 1; i<= N; i++) multiply = multiply * i;

Console.WriteLine($"Произведение чисел от 1 до {N} равно {multiply}");


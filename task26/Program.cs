// 26. Возведите число А в натуральную степень b используя цикл

// функция ввода числа с консоли
int InputNumber(string message)
{
    Console.Write(message);
    string? input = Console.ReadLine();
    return Convert.ToInt32(input);
    //return int.Parse(input);
}

int A = InputNumber("Введите число: ");
int b = InputNumber("Введите степень: ");
int result = 1;
for (int i = 1; i<= b; i++) result = result * A;

Console.WriteLine($"{A} в степени {b} равно: {result}");

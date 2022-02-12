// 23. Показать таблицу квадратов чисел от 1 до N 

// функция ввода числа с консоли
int InputNumber(string message)
{
    Console.Write(message);
    string? input = Console.ReadLine();
    return Convert.ToInt32(input);
}

int n = InputNumber("Введите число: ");
Console.WriteLine("Вы ввели N = " + n);
Console.WriteLine("Tаблицa квадратов чисел от 1 до N: ");

for (int i = 1; i <= n; i++) Console.WriteLine($"{i} x {i} = {Math.Pow(i, 2)} ");



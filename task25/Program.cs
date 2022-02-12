// 25. Найти сумму чисел от 1 до А

// функция ввода числа с консоли
int InputNumber(string message)
{
    Console.Write(message);
    string? input = Console.ReadLine();
    return Convert.ToInt32(input);
}
int N = InputNumber("Введите число: "); 
int summa = 0;
for (int i = 1; i<= N; i++) summa = summa + i;

Console.WriteLine($"Сумма чисел от 1 до {N} равна {summa}");

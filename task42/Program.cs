// 42. Определить сколько чисел больше 0 введено с клавиатуры

// функция ввода числа с консоли
int InputNumber(string message)
{
    Console.Write(message);
    string? input = Console.ReadLine();
    int.TryParse(input, out int number);
    //return Convert.ToInt32(input);
    return number;
}

int countPol = 1;
int countOtr = 1;
int a = InputNumber("Введите число: "); 
while ( a != 0) 
{
if (a>0) Console.WriteLine($"Вы ввели {countPol++} положительных чисел"); 
if (a<0) Console.WriteLine($"Вы ввели {countOtr++} отрицательных чисел");
System.Console.WriteLine("для окончания ввода введите 0 или Ctrl+C");
a = InputNumber("Введите число: "); 
}


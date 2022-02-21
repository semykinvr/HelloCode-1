// 44. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

// функция ввода числа с консоли
double InputNumber(string message)
{
    Console.Write(message);
    string? input = Console.ReadLine();
    double.TryParse(input, out double number);
    //return Convert.ToInt32(input);
    return number;
}

double k1 = InputNumber("Введите k1: ");
double b1 = InputNumber("Введите b1: ");
double k2 = InputNumber("Введите k2: ");
double b2 = InputNumber("Введите b2: ");
if (k1 == k2) Console.WriteLine("Прямые параллельны"); 
else
{
    double x = (b2-b1)/(k1-k2);
    double y = k1*x +b1;
    Console.WriteLine($"Прямые пересекаются в точке: X = {x}, Y = {y}");
}

